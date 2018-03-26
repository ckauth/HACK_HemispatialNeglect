# Motivation

_Hemispatial neglect syndrome_ is an anomaly that is caused by an injury to one of the cerebral hemispheres, which leads patients
to neglect, or _forget_, about half of the space that surrounds them. This injury prevents the brain from responding to stimulus
signals, coming from their left generally. Not seeing, hearing or feeling on their left, patients risk to hit obstacles when walking,
they read only the right side of a text, cut sentences in half, answer to somebody on their right although someone on their left side 
spoke to them, they draw only the right side of a picture, eat only the right side of what is contained on a plate, and so on.

Although all their senses work perfectly fine, the world on their right appears so exciting that it completely mutes stimuli coming
from their left, and the patients oftentimes are not aware of their situation. We took on that challenge by developing an _augmented reality_
game, that supports the patient during the rehabilitation phase, during which the odds of recovery are highest.

# Achievements

At the end of an inspiring and intense weekend, stands an augmented reality app intended to foster rehabilitation of hemispatial neglect patients.

![Demo](https://github.com/ckauth/HACK_HemispatialNeglect/blob/master/Illustrations/demo.gif)

The patient is given a hunter animal and shall move it with his hand to the corresponding hunted animal (a tiger chases a giraffe,
and it is common knowledge that an elephant is scared by a mouse). Once the hunter reaches his prey, the hunter avatar is changed,
and the patient's hunt continues on the opposite side. The game targets to extend the patient's perception to his left, and so the
elephant takes a step back after each successful hunt, thus increasing the difficulty of the next hunt on the left. Should the patient take
too much time to find the elephant, the elephant magnifies, to increase the stimulus and help the patient. Once out of vision, sound is 
added too, to mark the presence of the elephant. Note that elephant and giraffe hunts alternate, in order to recalibrate the patient on a 
starting point.

# Benefits of our Solution

* **Fun** - It is more fun to play and exercise in the interactive real world than on a static piece of paper.

* **Flexibile** - Rather than training in a guided session with his therapist, the patient is free to
	trains where and when he wants - the location and time of hunting are tracked and can be inspected a posteriori by the therapist.
	
* **Personalized** - The game level adapts immediately to the patient's overall or daily shape, and can be adjusted to foster
	improvement without causing frustration.
	
* **Low-cost** - Card-board augmented reality glasses are broadly affordable and their price is negligible compared to the price
	of a therapeutic session. (the hypothesis being that the patient owns a smartphone with camera)
	
* **Unintrusive** - The card-board and smartphone don't weigh much and are easily fixable with an elastic band around the patient's head.

![Overview](https://github.com/ckauth/HACK_HemispatialNeglect/blob/master/Illustrations/overview.jpg)

# Award

We are honored to being awarded the first prize of the [_Arkathon 2018 - Hacking Health Valais_](http://hacking-health.org/valais/)

![Overview](https://github.com/ckauth/HACK_HemispatialNeglect/blob/master/Illustrations/ceremony.jpg)

# User Guide

The project is written in C# for the [Unity](https://unity3d.com/) game engine, in combination with the [Vuforia](https://www.vuforia.com/)
augmented reality SDK. The code is as structured as a hackathon permits it to be ;)

To get started, all you need is a smartphone that runs Android, and some cardboard if you want to dive into the full experience.

The rules of the game are not complex, you may learn them from the above animation. Now have fun playing!


