                                                # code.fun.do-game
                                        a game for code fun do finals
                                                PROJECT IDEA

                                TEAM NAME                      :     UNI INJECTORS
                                APP NAME                         :     INERTZ ( Might change later on )
                                PLATFORMS TARGETED  :     MOBILE DEVICES / ANDROID/ IOS/ WINDOWS           
                                                  APP STORES
                                        TOOLS USED                     :     UNITY 3D


SUMMARY OF IDEA   :   Our idea for the Code.fun.do finals is of a simple game made in unity.For the first round of Code.fun.do we made a First Person Shooting game with 3D graphics and controlled the input through kinect gestures .However, for the second round we will strict to touch controlled input and follow a very simple yet addictive gameplay.

The motivation for making a game is the sheer amount of popularity mobile games get these days .The mobile gaming market has grown exponentially in the past 7-8 years and gives us a very huge opportunity for first time success. Additionally the members of the team are very interested in playing and developing games and mobile games give us just the right amount of challenge for beginning our journey in this field.

The idea for the game is to have a plate rotating about a pivot, having four boundaries or walls .A ball falls on the plate when the game starts and the user’s objective is to destroy the four sided wall by hitting it .The rotation of the plate is controlled through gyroscopic motion or simply touch (depends on which one provides a better gaming experience) and thus in turn the motion of the ball is controlled through gravity. However if the ball hits a gap in the wall it falls and the game gets over .The catch for the game is that the wall once destroyed starts growing back and thus the game becomes endless .The user plays for achieving a high score .We add different power ups and features as the difficulty increases ,but the most important thing to target is the simplicity of the game which has to be maintained both mechanically and aesthetically.Below is the first basic concept art generated for the game.



The procedure we will follow is to start by making simple and original graphics and designing the most basic features of the game first and follow it up with a series of prototyping while incorporating additional details to the game and constantly iterating. Although the game is endless, it will have some discrete difficulty stages which we have to analyze and design the features of the game accordingly which we believe should only be done after the basic framework is ready .Moreover the graphics will be aimed to be minimalistic and neat with the use of bright colors .

  

The focus will be on developing a very smooth and fluent control of the pivoted plate, ie. deliver an addictive feature just in controlling the ball motion on the inclined surface of the plate.The algorithm we design for making the game endless will also be prototyped and changed along the way so as to get an user experience where the game is neither frustrating nor boring and just satisfies the user’s need for upcoming challenges based on his acquired skills. 

We would like to add that the team welcomes any advice or changes mentioned by our mentors in the later stages of the development.We believe in starting with an extremely simple concept and adding to it along the way so that every detail is carefully analyzed and we are able to deliver a professional product in the end .








ADDITIONAL DETAILS 


How the algorithm works  :   Initially the wall is  just made up of four sides as a whole and once each side is struck it gets split into two and so on.
Therefore in the beginning of the game the wall has four sides ,the ball drops and if the user hits one of the wall it gets destroyed and starts regrowing but into two separate walls( Also the bigger the wall ,the more times you have to hit to destroy it). This is carried on as the game progresses and  each part of wall that one destroys gets split into two.The points scored depends on the time the player is able to keep the ball on the plate (however he has to hit the wall after certain time intervals and cannot just keep the ball at the center of the plane )  or it depends directly on the lenght of the wall the ball hits..Now the regrowth rate of the wall depends directly on its length.So if the length of the wall is small then it will take the wall longer to grow .


After this we can add powerups to make the game even more interesting .Some ideas can be :


Multiply  the number of balls on the plane ;say through this powerup we get two balls on the plane so they hit the walls simultaneously and the user can also afford to lose one of the balls.
Speed up the ball while freezing the scene .ie. the ball cannot go out of the plane and hits a lot of walls very fast deflecting from each one.
Some way through which we can let the user combine two parts of the wall so that the game  becomes easier .
