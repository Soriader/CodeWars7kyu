using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class WhoIsOnlineTask
	{

		public class User
		{
			public string Username { get; }
			public UserStatus Status { get; }
			public int LastActivity { get; }

			public User(string username, UserStatus status, int lastActivity)
			{
				Username = username;
				Status = status;
				LastActivity = lastActivity;
			}

			public enum UserStatus
			{
				Online,
				Offline,
				Away
			}

			public static Dictionary<UserStatus, IEnumerable<string>> WhosOnline(User[] friends)
			{
				if (friends == null || friends.Length == 0)
				{
					return new Dictionary<UserStatus, IEnumerable<string>>();
				}

				var online = new List<string>();
				var offline = new List<string>();
				var away = new List<string>();

				foreach (var user in friends)
				{
					if (user.Status == UserStatus.Offline)
					{
						offline.Add(user.Username);
					}
					else if (user.Status == UserStatus.Online)
					{
						if (user.LastActivity <= 10)
						{
							online.Add(user.Username);
						}
						else
						{
							away.Add(user.Username);
						}
					}
				}

				var result = new Dictionary<UserStatus, IEnumerable<string>>();
				if (online.Any()) result[UserStatus.Online] = online;
				if (offline.Any()) result[UserStatus.Offline] = offline;
				if (away.Any()) result[UserStatus.Away] = away;

				return result;


			}
		}
	}
}
//https://www.codewars.com/kata/5b6375f707a2664ada00002a/train/csharp