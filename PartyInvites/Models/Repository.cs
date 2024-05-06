/*
 * Repository
 * Author: Jaren Montano
 * Date: 12/1/2023
 * Purpose: The purpose of this
 * is to hold the items from our
 * form.
 */



namespace PartyInvites.Models
{
	public static class Repository
	{

		private static List<GuestResponse> responses = new List<GuestResponse>();
		public static IEnumerable<GuestResponse> Responses { get { return responses; } }

		public static void AddResponse(GuestResponse response)
		{
			responses.Add(response);
		}

	}
}
