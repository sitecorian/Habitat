﻿using Sitecore.Foundation.Alerts;
using Sitecore.Foundation.Alerts.Extensions;
using Sitecore.Foundation.Alerts.Models;

namespace Sitecore.Feature.Accounts.Controllers
{
  using System;
  using System.Web.Mvc;
  using System.Web.Security;
  using Sitecore;
  using Sitecore.Diagnostics;
  using Sitecore.Feature.Accounts.Attributes;
  using Sitecore.Feature.Accounts.Models;
  using Sitecore.Feature.Accounts.Repositories;
  using Sitecore.Feature.Accounts.Services;
  using Sitecore.Feature.Accounts.Texts;
  using Sitecore.Foundation.SitecoreExtensions.Attributes;
  using Sitecore.Foundation.SitecoreExtensions.Extensions;

  public class AccountsController : Controller
  {
    private readonly IAccountRepository accountRepository;
    private readonly INotificationService notificationService;
    private readonly IAccountsSettingsService accountsSettingsService;
    private readonly IUserProfileService userProfileService;
    private readonly IContactProfileService contactProfileService;

    public AccountsController() : this(new AccountRepository(new AccountTrackerService(new AccountsSettingsService())), new NotificationService(new AccountsSettingsService()), new AccountsSettingsService(), new UserProfileService(), new ContactProfileService())
    {
    }

    public AccountsController(IAccountRepository accountRepository, INotificationService notificationService, IAccountsSettingsService accountsSettingsService, IUserProfileService userProfileService, IContactProfileService contactProfileService)
    {
      this.accountRepository = accountRepository;
      this.notificationService = notificationService;
      this.accountsSettingsService = accountsSettingsService;
      this.userProfileService = userProfileService;
      this.contactProfileService = contactProfileService;
    }

    [AccountsRedirectAuthenticated]
    public ActionResult Register()
    {
      return this.View();
    }

    [HttpPost]
    [ValidateModel]
    [AccountsRedirectAuthenticated]
    [ValidateRenderingId]
    public ActionResult Register(RegistrationInfo registrationInfo)
    {
      if (this.accountRepository.Exists(registrationInfo.Email))
      {
        this.ModelState.AddModelError(nameof(registrationInfo.Email), Errors.UserAlreadyExists);

        return this.View(registrationInfo);
      }

      try
      {
        this.accountRepository.RegisterUser(registrationInfo.Email, registrationInfo.Password, this.userProfileService.GetUserDefaultProfileId());
        if (this.contactProfileService != null)
        {
          this.contactProfileService.SetPreferredEmail(registrationInfo.Email);
        }

        var link = this.accountsSettingsService.GetPageLinkOrDefault(Context.Item, Templates.AccountsSettings.Fields.AfterLoginPage, Context.Site.GetRootItem());
        return this.Redirect(link);
      }
      catch (MembershipCreateUserException ex)
      {
        Log.Error($"Can't create user with {registrationInfo.Email}", ex, this);
        this.ModelState.AddModelError(nameof(registrationInfo.Email), ex.Message);

        return this.View(registrationInfo);
      }
    }

    [AccountsRedirectAuthenticated]
    public ActionResult Login()
    {
      return this.View();
    }

    [HttpPost]
    [ValidateModel]
    [ValidateRenderingId]

    public ActionResult Login(LoginInfo loginInfo)
    {
      return this.Login(loginInfo, redirectUrl => new RedirectResult(redirectUrl));
    }

    protected virtual ActionResult Login(LoginInfo loginInfo, Func<string, ActionResult> redirectAction)
    {
      var result = this.accountRepository.Login(loginInfo.Email, loginInfo.Password);
      if (result)
      {
        var redirectUrl = loginInfo.ReturnUrl;
        if (string.IsNullOrEmpty(redirectUrl))
        {
          redirectUrl = this.accountsSettingsService.GetPageLinkOrDefault(Context.Item, Templates.AccountsSettings.Fields.AfterLoginPage, Context.Site.GetRootItem());
        }

        return redirectAction(redirectUrl);
      }

      this.ModelState.AddModelError("invalidCredentials", "Username or password is not valid.");

      return this.View(loginInfo);
    }

    [HttpPost]
    [ValidateModel]
    public ActionResult _Login(LoginInfo loginInfo)
    {
      return this.Login(loginInfo, redirectUrl => this.Json(new LoginResult
      {
        RedirectUrl = redirectUrl
      }));
    }

    [HttpPost]
    public ActionResult Logout()
    {
      this.accountRepository.Logout();

      return this.Redirect(Context.Site.GetRootItem().Url());
    }

    [AccountsRedirectAuthenticated]
    public ActionResult ForgotPassword()
    {
      return this.View();
    }

    [HttpPost]
    [ValidateModel]
    [AccountsRedirectAuthenticated]
    public ActionResult ForgotPassword(PasswordResetInfo model)
    {
      if (!this.accountRepository.Exists(model.Email))
      {
        this.ModelState.AddModelError(nameof(model.Email), Errors.UserDoesNotExist);

        return this.View(model);
      }

      try
      {
        var newPassword = this.accountRepository.RestorePassword(model.Email);
        this.notificationService.SendPassword(model.Email, newPassword);
        return this.InfoMessage(InfoMessage.Success(Captions.ResetPasswordSuccess));
      }
      catch (Exception ex)
      {
        Log.Error($"Can't reset password for user {model.Email}", ex, this);
        this.ModelState.AddModelError(nameof(model.Email), ex.Message);

        return this.View(model);
      }
    }

    [RedirectUnauthenticated]
    public ActionResult EditProfile()
    {
      if (!Context.PageMode.IsNormal)
      {
        return this.View(this.userProfileService.GetEmptyProfile());
      }

      if (this.userProfileService.GetUserDefaultProfileId() != Context.User.Profile.ProfileItemId)
      {
        return this.InfoMessage(InfoMessage.Error(Errors.ProfileMismatch));
      }

      var profile = this.userProfileService.GetProfile(Context.User.Profile);

      return this.View(profile);
    }

    [HttpPost]
    [RedirectUnauthenticated]
    public virtual ActionResult EditProfile(EditProfile profile)
    {
      if (this.userProfileService.GetUserDefaultProfileId() != Context.User.Profile.ProfileItemId)
      {
        return this.InfoMessage(InfoMessage.Error(Errors.ProfileMismatch));
      }

      if (!this.userProfileService.ValidateProfile(profile, this.ModelState))
      {
        profile.InterestTypes = this.userProfileService.GetInterests();
        return this.View(profile);
      }

      this.userProfileService.SetProfile(Context.User.Profile, profile);
      if (this.contactProfileService != null)
      {
        this.contactProfileService.SetProfile(profile);
      }

      Session["EditProfileMessage"] = new InfoMessage(Captions.EditProfileSuccess);
      return this.Redirect(Request.RawUrl);
    }
  }
}