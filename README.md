# TwitterAuthentication

1) To implement third party authentication with Twitter, you will need to sign in or sign up for a developers account by going to 
https://apps.twitter.com
2) Create a new application in the dev portal
3) After sign in is completed you will receive a consumer key and consumer secrey which will be used to authenticate to twitter
4) Your callback url should be something like http://localhost:52628/signin-twitter. In my case 52628 is the current port iis is running on.
5)You will need to add the client certificate in your Startup file (There was currently a bug where it didnt accept the client certificate and gave a 401 error message event if you had the right api key and secret
