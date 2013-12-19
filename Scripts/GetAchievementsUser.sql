Select * from Achievements as a
where AchievementId =
(Select Achievement_AchievementId from UserAchievements
where  User_UserId = 57 AND Achievement_AchievementId = a.AchievementId);



