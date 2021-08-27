<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128570779/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4275)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/PushpinAnimation/MainPage.xaml) (VB: [MainPage.xaml](./VB/PushpinAnimation/MainPage.xaml))
* [MainPage.xaml.cs](./CS/PushpinAnimation/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/PushpinAnimation/MainPage.xaml.vb))
<!-- default file list end -->
# How to animate a map pushpin
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4275)**
<!-- run online end -->


<p>This example illustrates how to provide animation for a map pushpin.<br />
</p><p>To do this, it is necessary to create a <a href="http://documentation.devexpress.com/#Silverlight/clsDevExpressXpfMapPushpinLocationAnimationtopic"><u>PushpinLocationAnimation</u></a> object and assign it to the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapMapPushpin_LocationChangedAnimationtopic"><u>MapPushpin.LocationChangedAnimation</u></a> property. After that it becomes possible to customize the animation duration (<a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapPushpinLocationAnimation_Durationtopic"><u>PushpinLocationAnimation.Duration</u></a>) and easing function (<a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapPushpinLocationAnimation_EasingFunctiontopic"><u>PushpinLocationAnimation.EasingFunction</u></a>). </p><p>In addition, you can change the pushpin state after its location animation is complete via the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapPushpinLocationAnimation_Completedtopic"><u>PushpinLocationAnimation.Completed</u></a> event.  In this example, this event is used to change the pushpin location randomly each time the bouncing animation effect is complete. </p><br />


<br/>


