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

There's a couple of reasons I chose to work with Unity in this course.

While it's completely possible to write your own game (or rendering) engine, it can take 1000 lines of code to render a single triangle on the screen using the most modern libraries (DirectX 12 or Vulkan). 
While Unity is not known for it's cutting edge graphics, cutting edge graphics are not really the most interesting from an educational point of view. W  