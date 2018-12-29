namespace RevStackCore.Identity.Mvc
{
    public class NotificationHead
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Highlight { get; set; }
    }

    public class BaseNotification
    {
        public string Id { get; set; }
        public string Company { get; set; }
        public string CompanyAddress { get; set; }
        public string CssHightlightColor { get; set; }
        public string CssLinkColor { get; set; }
        public string CompanyLogoUrl { get; set; }
        public string CompanyPhone { get; set; }
        public string TrackingUrl { get; set; }
        public string Email { get; set; }
        public string Valediction { get; set; }
    }

    public class TaskNotification : BaseNotification
    {
        public string Name { get; set; }
        public string Day { get; set; }
        public string DateString { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Action { get; set; }
        public string ActionLabel { get; set; }
    }
}
