# 3d Graphics Evaluation

## Procedure

* 6th of June at 1700 Belgian time I'll post a link to subscribe to an exam slot. If all the slots are full, just send me an email and I'll open extra slots
* I'll post two links, as the exam is on two days. Please register for the day you're assigned in your ISP. Otherwise I'll move you manually
* The exam is scheduled as 30 minutes
* Please show up at least 30 minutes early to your exam. If you're late to the exam, I'll give priority to anyone who is on time, so it could take several hours until it's your turn. 
* If I ask you to do your exam early because someone is late, you have the right to refuse, and do your exam at the scheduled time
* You have the right to do the exam or English or Dutch. Just tell me at any time which language you want to do the exam in, and I'll switch
* If I tell you the exam is done before those 30 minutes, it's not an indication of your final score, it just means I checked what I needed to check
* I'll show you your project on my machine. Do bring your own machine, just in case mine breaks, or we have different results
* I'll go through your code, looking for parts to discuss. I'll ask you what your code does, and I'll ask you why you implemented in that way, as well as the context of your code
* I'll also ask you to confirm what features I have found missing during my earlier grading
* I'll also ask you questions about the theory of 3d graphics, often as it's relevant to your code, but also in general
* I might ask you to draw something on the whiteboard. If you're not comfortable with that, I should have some scrap paper and a pen as well. The reasoning is that many things in 3d graphics are best explained graphically

## Example exam questions

Beware, I can ask you any of the following questions, no matter what or how you implemented the requirements of the projects. Which means, I can ask you about something even if it doesn't feature in your code. Also, this list in *not* exhaustive, I will ask you questions that are not on this list. An example would be follow-up questions. It's merely meant to give you and idea about the content covered, and in which way. 

* What is the normal? 
* What is the face normal?
* What is the vertex normal?
* How do you calculate the face normal?
* What is the dot product? What are the parameters, and what does it compute? What is the range of the return value?
* What is the cross product? What are the parameters, and what does it compute? 
* What is procedural generation?
* When would you use procedural generation?
* What is aliasing?
* Do you have aliasing in your render? Where?
* What is mipmapping?
* What is the relationship between mipmapping and aliasing?
* What is anti-aliasing?
* Give an example of anti-aliasing
* What is a vertex shader? What does it typically do?
* What is a pixel/fragment shader? What does it typically do?
* What is the rasterizer?
* What is a vertex? What is typically in a vertex
* What is an index buffer?
* What is a triangle's winding?
* Give two differences between offline rendering and real time rendering 
* What is handedness?
* What are transform spaces? How do you move from one to the other?
* What is view space?
* What is a material/BRDF? Give an example
* What is the difference between diffuse and specular lighting?
* How can you tell the difference between diffuse and specular lighting?
* How do mirrors work?
* What are some reasons to use proceduralism?
* Give an advantage and a disadvantage of procedural generation
* What is a heightmap?
* How can we use a mathematical function like *sin* to make terrain?
* How does value (or perlin) noise work? 
* How can we map a 2D texture onto a 3D object?
* What is temporal aliasing?
* What is an LOD?
* Which steps happen when you submit a mesh to the GPU?
* What is a depth buffer? Discuss one usage
* How do shadows work?
* What a perspective camera? Discuss it's parameters / geometry (frustum)
* What are two different kinds of camera types
* What is field of view (FOV)
* Compare raytracing to rasterizer: their advantages, disadvantages
* What does 'rendering' mean?
* What is the "primary visibility" problem?
* How does a rasterizer solve the primary visibility problem?
* How does a forward renderer work?
* How does a deferred renderer work?
* What are the advantages / disadvantages of a forward renderer?
* What are the advantages / disadvantages of a deferred renderer?
* What is a gbuffer?
* What is tonemapping? How does it work?
* What is finite differencing? Given an example of when you would use finite differencing


## Things you don't need to know

* Everything about foveated rendering and VRS (you do need to know some things from the presentation, specifically about aliasing in general)
* What the abbreviation BRDF stand for
* Gooch shading, except for the fact that it's an example of a BRDF
* Team Fortress 2 rendering, except for the fact that it has an example of a BRDF
* Specific video games and facts about them. For example,  you do need to know about the general principles of proceduralism, but not the games we talked about. I won't ask you "How did Elite use proceduralism to make worlds?", but I can ask you "How can proceduralism be used to create worlds?"
* Voronoi functions
* L-Systems
* Tiny glade
* Ambient Occlusion
* Bloom

## Grading 

Grading is done is 3 multiplicative steps
* Each feature in the project documentation will be checked in your project beforehand, and I'll confirm with you during the exam. You will get a grade on how much you managed to implement.
* You will be asked about these features, the theory behind them, as well as general questions about 3d graphics. You will be receive a percentage as a grade depending on how complete / correct your answers are.
* You will receive a deduction based on any violations of the requirement.

These values are multiplied together. This means that you need a passing grade on both the project and the theory. 

## General advice

* Show up! If your project is not done, hand it in, and register for the exam. Too many times I've seen student's 'flunk themselves', by thinking it's hopeless and not showing up. I'm the one responsible for that :) Hand in, show up, even if you fail, you'll be reassured when you retake, as you'll know how exam goes, and you'll have had feedback on your project
* Focus on the big picture. I think it's more important that you know the context of all the different things in the course and how they fit together compared to knowing specific details.
* Answer confidently and honestly. By confidently, I mean that if you think you know something, just state it as fact. Like you're discussing with another student during labs. By honestly, I mean that if you don't know something, just say it that way. 
* 30 minutes is a lot of time. If you need a minute to think about things, just ask for it. I might hurry you along if our time is running out and I think it's in your best interest to move on, but in general we have more than enough time.
