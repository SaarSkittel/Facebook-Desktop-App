# Facebook-Desktop-App
## Introduction

Facebook desktop app created in C# as a part of design pattern course.

## Concept
This app main purpose is to implement and understand common design patterns.
This app uses Facebook api and Facebook wrapper made by the course lecturer  

## App Flow
When you first run the app there greeted with the sign in. after signing in you will be presented with your home page that consists of your liked pages, favorite teams, friends, events, friends birthday, albums, posts and the option to send a post.


## Design Patterns Used

### Static Factory Class

In the app there is polymorph clock family for both event count down and birthday count down. That is why we created a static class that will be in charge of creating the clock with a static method.

### Façade
To make the logic layer encapsulated from the UI there was a need to create a façade class. This class handles all the subsystems (like User, LoginResult, Clock and LoginDetails) so the UI uses only simplified actions.

### Adapter
The app uses collections which the UI can’t use. So there was a need to create an adapter between the collections to a format that the UI can use.
Strategy

In the app there are different types of collections. So to avoid duplicating code when using the adapter we used strategy to maintain the adapting relevant and to assist in further maintenance. 


### Observer

The observer was used in order inform the UI that a change was made in the user data.


### Decorator 

We used decorator to inform visually when an update was made by blinking and making a sound where a change was made.
