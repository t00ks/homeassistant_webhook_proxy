# homeassistant_webhook_proxy
This is a very basic, not really well thought our proxy that allows you to use GET requests for [Home Assistant](https://www.home-assistant.io/)

# Installation

- Change the `LOCAL_IPADDRESS` in `WebProxyController` to be the IP address of you Home Assistant
- Follow the instructions on how to create an add-on (All you should need to do really is copy the contents of this repo to the addons folder in Home Assistant) [HERE](https://developers.home-assistant.io/docs/add-ons/)
- Once the add-on is running, you can then make a GET request to `https://{YourIpAddress}:7123/api/web_hook_proxy/{web_hook_name}` to trigger your Home Assistant Web Hook
