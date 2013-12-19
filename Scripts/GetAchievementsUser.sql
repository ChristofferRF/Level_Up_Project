Select TOP 1 * from Achievements as a
where AchievementId =
(Select Achievement_AchievementId from UserAchievements
where  User_UserId = 57 AND Achievement_AchievementId = a.AchievementId)
Order By AchievementId DESC



