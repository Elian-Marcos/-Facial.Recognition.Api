namespace Meetings.Management.Application.Commands.Response.Person
{
    public class CreateMeetingResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
