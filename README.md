liferay-push-windowsphone
======================

Service for Liferay SDK Windows Phone for Push Notifications. It's an extension for [Ithildir](https://github.com/Ithildir/liferay-sdk-builder-windows) and [Bruno Farache IOS Service] (https://github.com/brunofarache/liferay-push-ios)

If you find any bug, please create a Issue.
``` 
Liferay.connect(null, null, 'http://10.0.2.2:8080', 'test@liferay.com', 'test' );
``` 
## Installation
``` 
Copy the folder Notification and paste in Liferay Services project or folder.
``` 

### Methods

- AddPushNotificationsDeviceAsync(string token, string platform)
- DeletePushNotificationsDeviceAsync(string token)
- SendPushNotificationWithToUserIdsAsync(IEnumerable<int> toUserIds, string payload)
- SendPushNotificationWithPlatformAsync(string platform, IEnumerable<string> tokens, string payload)

##More info:

For more information read [Bruno Farache IOS Service] (https://github.com/brunofarache/liferay-push-ios)
