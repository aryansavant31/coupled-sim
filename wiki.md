## Week 2
* The entire group installed unity and forked the coupled sim repository.
### Idea - What will we research on?
The group brainstormed on a few research topics. One of which was pedestrian-vehicle interaction. In this experiment, we are intersted to know what the pedestrian looks at when looking at a AV. Is it 
* the 'supposed' driver sitting on the driver seat, 
* the passenger next to him or
* a screen mounted in the front of AV that has eyes.

## Week 3
The main focus of this week was to learn the basics of unity. 
### Things that we learnt about unity
* We got to understand a basic overview of hierarchy of unity ( i.e. scene is parent, then game object, then components etc.). 
* Additionally, we learnt how to navigate around the map, view objects and its properties and were able to drive a car in the given environment. 
* We also were able to conduct sessions where one of our group member was the host and other two were clients. This was done on 3 separate systems. Along with that, we were able to assign roles for different clients (One was driver, other was pedestrian). The demo example provided in the coupled-sim repository was used to conduct these sessions. 

### Things yet to be learned
* We still need to understand how to add custom objects in a scene. 
* We also need to learn how scripts in unity work so that we can program a car to behave autonomous. 

Apart from that, the group will explore on more scenarios to apply the course learnings apart from the idea discussed in week 2. 

## Week 4
Many ideas were brainstormed. The main thing we Wanted to decide is whether our situation should be AV to pedestrian or AV to passenger. We finally settled on a situation that can solve one of the many critical problem of AV adoption. That is how to hand over the control to the human driver in emergency situation. There can be a screen inside in front of the driver where it indicates how confident the autonomous vehicle is in what it is doing. 

So there are three stages of the confidence of the autonomous vehicle. The highest level is the confident level the second is just confused level and the third is a breakdown level. 

The confident level means the AV knows what it's doing and the passenger or the driver can just relax. The confused level is like the AV is not really sure what it should do. so maybe it's seen a cone and it doesn't whether it's a car or a cone. 
The third is a breakdown level where the driver MUST TAKE OVER as the AV software is broken.

So the benefit of having these three stages is that when the av is on a confused level the driver should be alert to take over. It's an intermediate step before fully taking over the car. 

Also in the confused level, AV can ask driver what to do (like select a choice) so driver is helping AV decide in that level. We imagine situations like if AV is taking things too safe and due to that it doesn't overtake even if there is huge gap, it can just confirm overtake from driver.

So the group members have delegated tasks where one member will work on the interior design and the other member will work on the scripts that will dictate how the car will behave in various situations. Then based on the situation, the confident, confused and breakdown level will be flashed on the screen and we hope to see how easy is it for driver to react compared to a traditional AV which will inform the driver to take over in the last second of an emergency.
