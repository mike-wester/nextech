using System;
namespace nextech_api.Models
{
	public class Story
	{
		public int Id { get; set; }                  // The item's unique id.
        public Boolean Deleted { get; set; }         // true if the item is deleted.
        public string? Type { get; set; }             // The type of item. One of "job", "story", "comment", "poll", or "pollopt".
        public string? By { get; set; }               // The username of the item's author.
        public int? Time { get; set; }                // Creation date of the item, in Unix Time.
        public string? Text { get; set; }             // The comment, story or poll text. HTML.
        public Boolean Dead { get; set; }            // true if the item is dead.
        public int? Parent { get; set; }              // The comment's parent: either another comment or the relevant story.
        public int? Poll { get; set; }                // The pollopt's associated poll.
        public int[]? Kids { get; set; }              // The ids of the item's comments, in ranked display order.
        public string? Url { get; set; }              // The URL of the story.
        public int? Score { get; set; }               // The story's score, or the votes for a pollopt.
        public string? Title { get; set; }            // The title of the story, poll or job. HTML.
        public int[]? Parts { get; set; }             // A list of related pollopts, in display order.
        public int? Descendants { get; set; }       // In the case of stories or polls, the total comment count.
    }
}

