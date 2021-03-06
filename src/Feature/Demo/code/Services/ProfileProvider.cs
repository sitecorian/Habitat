﻿namespace Sitecore.Feature.Demo.Services
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Sitecore.Analytics;
  using Sitecore.Analytics.Data.Items;
  using Sitecore.Cintel.Reporting.Contact.ProfilePatternMatch.Processors;
  using Sitecore.Common;
  using Sitecore.Data.Fields;
  using Sitecore.Feature.Demo.Models;
  using Sitecore.Foundation.SitecoreExtensions.Extensions;
  using Sitecore.Resources.Media;

  public class ProfileProvider : IProfileProvider
  {
    public IEnumerable<ProfileItem> GetSiteProfiles()
    {
      var settingsItem = Context.Site.GetContextItem(Templates.ProfilingSettings.ID);
      if (settingsItem == null)
      {
        return Enumerable.Empty<ProfileItem>();
      }
      MultilistField profiles = settingsItem.Fields[Templates.ProfilingSettings.Fields.SiteProfiles];
      return profiles.GetItems().Select(i => new ProfileItem(i));
    }

    public bool HasMatchingPattern(ProfileItem currentProfile)
    {
      var userPattern = Tracker.Current.Interaction.Profiles[currentProfile.Name];
      if (userPattern?.PatternId == null)
      {
        return false;
      }
      var matchingPattern = Context.Database.GetItem(userPattern.PatternId.Value.ToID());
      return matchingPattern != null;
    }

    public IEnumerable<PatternMatch> GetPatternsWithGravityShare(ProfileItem visibleProfile)
    {

      var userPattern = visibleProfile.PatternSpace.CreatePattern(Tracker.Current.Interaction.Profiles[visibleProfile.Name]);

      var patterns = PopulateProfilePatternMatchesWithXdbData.GetPatternsWithGravityShare(visibleProfile, userPattern);
      return patterns.Select(patternKeyValuePair => CreatePatternMatch(visibleProfile, patternKeyValuePair));
    }

    private static PatternMatch CreatePatternMatch(ProfileItem visibleProfile, KeyValuePair<PatternCardItem, double> patternKeyValuePair)
    {
      return new PatternMatch(visibleProfile.NameField, patternKeyValuePair.Key.NameField, GetPatternImageUrl(patternKeyValuePair), patternKeyValuePair.Value);
    }

    private static string GetPatternImageUrl(KeyValuePair<PatternCardItem, double> patternKeyValuePair)
    {
      return patternKeyValuePair.Key.Image?.MediaItem == null ? string.Empty : patternKeyValuePair.Key.Image.ImageUrl(new MediaUrlOptions { Width = 50, MaxWidth = 50 });
    }
  }
}