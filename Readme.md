<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/PushpinAnimation/MainPage.xaml) (VB: [MainPage.xaml](./VB/PushpinAnimation/MainPage.xaml))
* [MainPage.xaml.cs](./CS/PushpinAnimation/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/PushpinAnimation/MainPage.xaml))
<!-- default file list end -->
# How to animate a map pushpin


<p>This example illustrates how to provide animation for a map pushpin.<br />
</p><p>To do this, it is necessary to create a <a href="http://documentation.devexpress.com/#Silverlight/clsDevExpressXpfMapPushpinLocationAnimationtopic"><u>PushpinLocationAnimation</u></a> object and assign it to the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapMapPushpin_LocationChangedAnimationtopic"><u>MapPushpin.LocationChangedAnimation</u></a> property. After that it becomes possible to customize the animation duration (<a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapPushpinLocationAnimation_Durationtopic"><u>PushpinLocationAnimation.Duration</u></a>) and easing function (<a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapPushpinLocationAnimation_EasingFunctiontopic"><u>PushpinLocationAnimation.EasingFunction</u></a>). </p><p>In addition, you can change the pushpin state after its location animation is complete via the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapPushpinLocationAnimation_Completedtopic"><u>PushpinLocationAnimation.Completed</u></a> event.  In this example, this event is used to change the pushpin location randomly each time the bouncing animation effect is complete. </p><br />


<br/>


