/*
 * GuestResponse
 * Author: Jaren Montano
 * Date: 12/1/2023
 * Purpose: This is the object
 * that holds that data
 * that is retrived from the user.
 */





using System.ComponentModel.DataAnnotations;


namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public  string? Name { get; set; }

		[Required(ErrorMessage = "Please enter your E-Mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Please enter your Phone")]
		public string? Phone { get; set; }

		[Required(ErrorMessage = "Please specify whether you will attend")]
		public bool? WillAttend { get; set; }

    }
}
