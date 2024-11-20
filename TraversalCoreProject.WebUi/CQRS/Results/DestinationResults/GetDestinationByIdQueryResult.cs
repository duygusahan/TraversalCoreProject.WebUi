namespace TraversalCoreProject.WebUi.CQRS.Results.DestinationResults
{
    public class GetDestinationByIdQueryResult
    {
        public int DestinationId { get; set; }

        public string City { get; set; }
        public string Daynight { get; set; }
        public string Price { get; set; }
    }
}
