<h1>Unity-Timer-Script</h1>
A simple unity timer script which can be used to call a unity event<br>
===================================================================<br>
To use this Timer on any of your unity gameobjects, you need to add the 'TimerBehaviour' monobehaviour as a component to your desired object.
Then you can adjust its properties in the inspector tab.
 - The 'Time' float is the amount of time the timer will countdown from;
 - The 'Active On Start' bool determines whether the timer will be started when the Start event function is called
 
The timer can also be 'triggered' from other scripts by accessing the TimerBehaviour component and calling the 'StartTimer' method
There is the option to pass a float through this method so that you can set the timer's time as well as trigger the timer.

You can also set the timer's time from other scripts by passing a desired float through the 'SetTime' method.
