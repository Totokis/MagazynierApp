self.addEventListener('install', async event => {
    console.log('Installing service worker...');
    self.skipWaiting();
});

self.addEventListener('fetch', event => {
    // You can add custom logic here for controlling whether to use cached data if offline, etc.
    // The following line opts out, so requests go directly to the network as usual.
    return null;
});

self.addEventListener('push', event => {
    const payload = event.data.json();
    event.waitUntil(
        self.registration.showNotification(payload.title, {
            body: payload.message,
            icon: payload.iconUrl,
            vibrate: [100, 50, 100],
        })
    );
});

self.addEventListener('notificationclick', event => {
    event.notification.close();
});