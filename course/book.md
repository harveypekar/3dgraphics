# 3d Graphics

## Foreword

Welcome everyone to the book for the course of 3d graphics. First of all, I would like to express how happy I am for teaching this course, for a lot of different reasons. It's a surprisingly varied topic, touching on subjects such as physics, mathematics, material science, software optimization, hardware design, aesthetics, human computer interaction, and many more. This is both a blessing and curse, which you might experience in this course. It's nice that there are a lot of different topics, but it can be a bit frustrating that the bigger picture (how we can use a pc to make an image) can seem vague until all the seperate pieces have already been understood.
On a more personal note, I was a graphics programmer for a long time. I started by accident, I wanted to get into game programming, and due to circumstances met someone who specialized in graphics, leading me down the same path. I've never regretted it, the day-to-day of the topic is interesting, but due to the visual feedback and speed (it moves!) it has always been highly motivating. 
I hope you find this course as interesting as I find the entire topic,
Daan Nijs

## Introduction

In this course, we will be looking at how computers create (or 'render') images. Each application does render their images in their own way, using diffent algorithms, or they use a library or engine (think 'Unity' or 'Unreal') that they configure to give the application the needed look.
Of course, we will not just be looking at how other applications do it, we will code our own solutions to some common 3d problems, and develop our own rendering solutions. 

We will also limit ourselves to "real-time rendering". This is the type of rendering that can handle a user changing the camera, as it's continously updating the rendered image. A typical example would be video games, but also think of any VR application, DCC applications such as Blender, 3D cad applications such as AutoCAD, but also Photoshop, Premiere, Snapchat Filters, etc...

The opposite of "real-time rendering" doesn't really have a name, but is commonly referred to as "offline rendering". This refers to the fact the image is rendered long before it's needed. A typical example would be an animated movie. It might be rendered months before you get to see it. And this comes with some 

We will be taking advantage of Unity3d, a game engine, to do this (introduced in a following chapter). 


## Unity

### Motivation

There's a couple of reasons I chose to work with Unity in this course. It was obvious to me that I wanted you to work with an existing engine. While writing your own engine is a very satisfying and educational exercise, it would involve writing a lot of code (rendering a single triangle in Vulkan involves hundreds of lines of code), and likely would involve learning a more complicated language like Rust or C++.

Choosing between engines was not hard. While I know and like Unreal the best, it's low level C++ and high level blueprints make it awkward to teach to people who don't know either. Godot is for me unknown, and I've gotten some mixed feedback. 
Meanwhile, Unity uses C# as it's scripting language. It's relatively simple, nad very similar to Java. It's a very powerful language in it's own right, and even if you will never use Unity af this this course, there's a good chance you will encounter it, for example in Powershell, or when using the .NET platform.
Unity is also the most popular game engine out there, and is used in other courses at UCLL. It also means that it's the easiest engine to find tutorials, questions / answers on stackoverflow, libraries, etc...

## 3D basics

### Coordinate system

We will be working with a 3d coordinate system. In a 3d coordinate system, we have 3 axis: X, Y and Z. The place where the axis originate is called the origin.


In Unity, the 3 axis have a common agreed upon meaning:

* the X axis represents the direction towards the right
* the Y axis represents the upwards direction
* the Z axis represents the directionp pointing into the screen.

Take your left hand, and hold your thumb, index, and middle finger perpendicular to eachother. Put your thumb in the direction of the X axis, and your middle finger in the direfction of the Y axis. If you did it right (and have normal human hands), you should have your middle finger pointing upwards. Try it with your right hand. You shall find that it's impossible to align your fingers with the axes the same way. 

This is a fundamental property of Unity's coordinate system, we call such a coordinate system a *left-handed coordinate sytem*. There are plenty of other engines with a right coordinate system, but for now just assume we live in a left handed universe. 

Unity also has Y as the up vector. This is an arbitrary choice: in a game about space, for example, what "up" means can change at any time, depending on the orientation of the player (more correctly : the camera). But it is a useful tool, as most applications will have a meaningful up. This enables people making models, or plugins to all us Y as the up vector, and everything will be oriented in the right way by default.

The take away here, is that Unity has a *left-handed coordinate system* and has Y as the up vector.

### Points and vectors

Now that we have our coordinate system, we can define locations in it, also called points. Points are defined as a tuple of 3 floating point numbers. 
For example, the origin is a point, and will always have position (0, 0, 0). We could also define a point (2, 1, 3). This point will be 2 units right of the origin, one unit higher, and 3 units deeper (into the screen).

A vector is a direction. For example, we can have 2 points A (1, 0, 0) and B (2, 0, 0). B's direction relative to A is the vector (1, 0, 0).

Both points and vectors are implemented by unity's ['Vector3' class](https://docs.unity3d.com/ScriptReference/Vector3.html), which is a tuple of 3 'float's.

Vectors can be indexed by their component. For example, if we're only interested in the X part of a vector, we can use 'Vector3.x' syntax.

The difference between a vector and a point is subtle, and it's honestly not all that important. The most important thing is that some mathematical operations only make sense with vectors. If you're aware of whether you're working with points or vector's, you can occasionally notice that you're trying to do something that doesn't make logical sense.

#### Addition

We can freely add two vectors together. For example, '(1, 0, 0) + (0, 1, 0) = (1, 1, 0)'. The order in which you add them is irrelevant, we could have swapped them around for the same result: '(0, 1, 0) + (1, 0, 0) = (1, 1, 0)'

To make it less abstract, let's take 2 cities: Brussels and Hasselt. Brussels lies at (0, 0, 0). Hasselt lies at (90, 0, 0). We start in Brussels, and drive 50km east, and get pump some gas. We continue driving for another 40km and arrive. We drove the following vectors : (50, 0, 0) and (40, 0, 0). In total we drove (50, 0, 0) + (40, 0, 0) = (90, 0, 0), which is our destination. This makes sense.


We can freely add a point and a vector together. For example, we can express "10km east of Hasselt" as (90, 0, 0) + (10, 0, 0) = (100, 0, 0). The result is a point.


We can **not** add 2 points together. To understand why, remember that vector's are directions. Hasselts position is a point (90, 0, 0). Antwerp's position is a point (0, 0, 60). I find it hard to image what the meaning is of adding both of their positions together

I'm not going to point out the differences between points and vectors in he rest of the course, as in practice everyone talks about vectors, but I encourage you to keep it in mind. If you do that, you'll find it easier to find mistakes in your 3d logic.

### Subtraction

Negation work very similar to addition. Given 'A-B', we subtract all B's components from the corresponding components of A, giving 'A-B = (A.x - B.x, A.y - B.y, A.z - B.z)'. Of course the order does matter a lot here!

The use case for negation is very different from addion. It's also super useful and we're going to use it all the time.

To recap:
Hasselt is at (90, 0, 0)
Antwerp is at (0, 0, 60)