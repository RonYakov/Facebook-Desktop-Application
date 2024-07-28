# Facebook Desktop App
## Overview
The Facebook app provides users with access to their Facebook profiles and the ability to modify them. Leveraging the Facebook API, the app offers a seamless experience, incorporating advanced features such as multithreading and various design patterns to ensure optimal performance and scalability.
 
## Design Patterns Utilized
1. Singleton
* Reason for Usage: The Singleton pattern ensures that there is only one instance of the loggedInUser across multiple forms within the application. This is crucial to maintain a consistent user state.
* Implementation: Double Check Locking - Used when performing login or accessing the loggedInUser in FormMain. This ensures that no more than one instance of loggedInUser exists at any given time.
2. Strategy
* Reason for Usage: The Strategy pattern allows for flexibility in changing the maximum value of graphs in the future without modifying the existing code structure.
* Implementation: Class Structure - DiagramCreator class contains a composition of PostChartTopValue. The MaxPostChartValue class implements PostChartTopValue to determine the maximum value of the graph.
3. Observer
* Reason for Usage: The Observer pattern is implemented to notify multiple components in the system when a user posts a new status, facilitating better communication and updates.
* Implementation: Event Handling - The postManager class includes a public event that all interested components can subscribe to for updates on new posts.
4. Facade 
* Reason for Usage: The Facade pattern simplifies the interaction with the FacebookUser data by presenting only the relevant information to the user in the feed, improving the user experience.
* Implementation: Facade Class - FormFeedInitializerFacade serves as a facade for FormFeed, providing the necessary data in the expected format.
 
## Features
* Download Images from User Albums: Allows users to download images from their photo albums to their computer.
* Graphical Representation of User Activity: Displays the number of statuses and photos uploaded by the user each month in a graphical format.
 
## Development Context
The Facebook app is built using C# and WinForms and was created as part of a design pattern course at the Academic College of Tel Aviv Yaffo.
 
## Installation
To install the Facebook app, follow these steps:
1. Clone the repository from GitHub.
2. Open the solution file in Visual Studio.
3. Install the required packages.
4. Build the solution and run the app.
 
## Usage
To use the Facebook app, follow these steps:
1. Log in to the app using your Facebook credentials.
2. Navigate to the desired feature from the app menu.
3. Enjoy the features and have fun!
