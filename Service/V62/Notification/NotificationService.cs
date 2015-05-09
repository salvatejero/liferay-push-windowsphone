using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liferay.SDK.Service.V62.Notification
{
    class NotificationService: ServiceBase
	{
        public NotificationService(ISession session)
			: base(session)
		{
		}


        public async Task<dynamic> AddPushNotificationsDeviceAsync(string token, string platform)
        {
            var _parameters = new JsonObject();

            _parameters.Add("token", token);
            _parameters.Add("platform", platform);

            var _command = new JsonObject()
			{
				{ "/push-notifications-portlet/pushnotificationsdevice/add-push-notifications-device", _parameters }
			};

            var _obj = await this.Session.InvokeAsync(_command).ConfigureAwait(false);

            return (dynamic)_obj;
        }

        public async Task<dynamic> DeletePushNotificationsDeviceAsync(string token)
        {
            var _parameters = new JsonObject();

            _parameters.Add("token", token);

            var _command = new JsonObject()
			{
				{ "/push-notifications-portlet/pushnotificationsdevice/delete-push-notifications-device", _parameters }
			};

            var _obj = await this.Session.InvokeAsync(_command).ConfigureAwait(false);

            return (dynamic)_obj;
        }

        public async Task<dynamic> SendPushNotificationWithToUserIdsAsync(IEnumerable<int> toUserIds, string payload)
        {
            var _parameters = new JsonObject();

            _parameters.Add("toUserIds", toUserIds);
            _parameters.Add("payload", payload);

            var _command = new JsonObject()
			{
				{ "/push-notifications-portlet/pushnotificationsdevice/send-push-notification", _parameters }
			};

            var _obj = await this.Session.InvokeAsync(_command).ConfigureAwait(false);

            return (dynamic)_obj;
        }

        public async Task<dynamic> SendPushNotificationWithPlatformAsync(string platform, IEnumerable<string> tokens, string payload)
        {
            var _parameters = new JsonObject();

            _parameters.Add("platform", platform);
            _parameters.Add("tokens", tokens);
            _parameters.Add("payload", payload);

            var _command = new JsonObject()
			{
				{ "/push-notifications-portlet/pushnotificationsdevice/send-push-notification", _parameters }
			};

            var _obj = await this.Session.InvokeAsync(_command).ConfigureAwait(false);

            return (dynamic)_obj;
        }
    }
}
