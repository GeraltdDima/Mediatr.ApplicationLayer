using MediatR;

namespace Mediatr.ApplicationLayer.Observability.Handlers.MediatrNotificationHandler
{
    public abstract class MediatrNotificationHandler<TNotification> : INotificationHandler<TNotification>
        where TNotification : INotification
    {
        private event EventHandler Handled;

        public MediatrNotificationHandler(EventHandler handled)
        {
            Handled = handled;
        }
        
        public delegate Task EventHandler(TNotification notification);

        protected void OnEnable(EventHandler handled)
        {
            Handled += handled;
        }
        
        protected void OnDisable(EventHandler handled)
        {
            Handled -= handled;
        }

        public async Task Handle(TNotification notification, CancellationToken cancellationToken)
        {
            await Handled.Invoke(notification);
        }
    }
}