using System;

namespace Twilio
{
	/// <summary>
	/// An Participant instance resource represents a single Twilio conference Participant.
	/// </summary>
	public sealed class Participant //: TwilioBase
	{
        /// <summary>
        /// Exception encountered during API request
        /// </summary>
        public RestException RestException { get; set; }
        /// <summary>
        /// The URI for this resource, relative to https://api.twilio.com
        /// </summary>
        public Uri Uri { get; set; }


		/// <summary>
		/// A 34 character string that identifies the conference this participant is in
		/// </summary>
		public string ConferenceSid { get; set; }
		/// <summary>
		/// The unique id of the Account that created this conference
		/// </summary>
		public string AccountSid { get; set; }
		/// <summary>
		/// A 34 character string that uniquely identifies the call that is connected to this conference
		/// </summary>
		public string CallSid { get; set; }
		/// <summary>
		/// true if this participant is currently muted. false otherwise.
		/// </summary>
		public bool Muted { get; set; }
		/// <summary>
		/// Was the startConferenceOnEnter attribute set on this participant (true or false)?
		/// </summary>
		public bool StartConferenceOnEnter { get; set; }
		/// <summary>
		/// Was the endConferenceOnExit attribute set on this participant (true or false)?
		/// </summary>
		public bool EndConferenceOnExit { get; set; }
		/// <summary>
		/// The date that this resource was created
		/// </summary>
		public DateTimeOffset DateCreated { get; set; }
		/// <summary>
		/// The date that this resource was last updated
		/// </summary>
		public DateTimeOffset DateUpdated { get; set; }
	}
}