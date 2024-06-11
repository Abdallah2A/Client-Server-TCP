# Project Title: Client-Server File and Directory Manager
## Project Description
This project is a simple client-server application built using C# and Windows Forms. It allows clients to connect to a server, send messages, request directory listings, and download files. The server can handle multiple clients simultaneously and respond to their requests for directory contents and file transfers.

## Features

### Server:
- Accepts multiple client connections.
- Handles incoming messages and requests from clients.
- Provides directory listings.
- Sends requested files (compressed using GZip).
- Displays status updates and messages from clients.

### Client:
- Connects to the server.
- Sends messages and requests to the server.
- Receives directory listings.
- Downloads and decompresses files.
- Displays status updates and messages from the server.
- Getting Started


## Prerequisites
1- .NET Framework (4.8 or higher recommended)

2- Visual Studio (or any other C# IDE)


## Installation
1- Clone the repository to your local machine:

```bash
git clone https://github.com/Abdallah2A/Client-Server-TCP
```
2- Open the project in Visual Studio.

## Running the Server
1- Navigate to the Project_Server folder.

2- Open Form1.cs in Visual Studio.

3- Build and run the project.

4- The server will start listening on 127.0.0.1:5000.

## Running the Client
1- Navigate to the Project_Client folder.

2- Open Form1.cs in Visual Studio.

3- Build and run the project.

4- The client will connect to the server at 127.0.0.1:5000.

## Usage
### Server
- The server automatically starts listening for client connections upon running.
- Connected clients are displayed in a list.
- Incoming messages and status updates are shown in the status area.
- The server can be stopped, which will disconnect all clients.

### Client
- The client connects to the server upon running.
- Messages can be sent to the server using the message input box and send button.
- Directories can be requested by entering the path and clicking the "Ask Dir" button.
- Files can be requested by entering the path and clicking the "Ask File" button.
- Media files can be requested and streamed by entering the path and clicking the "Ask Stream" button.
- Received directories and files are displayed in the respective areas.

## Code Overview
### Server Code (Project_Server)
Form1.cs:
- Initializes the server and starts listening for client connections.
- Accepts incoming client connections and manages a list of connected clients.
- Handles incoming messages and requests for directories and files.
- Compresses files using GZip before sending to clients.
- Provides status updates in the server UI.

### Client Code (Project_Client)
Form1.cs:
- Connects to the server and initializes communication streams.
- Sends messages and requests to the server.
- Receives messages, directory listings, and files from the server.
- Decompresses received files and saves them locally.
- Provides status updates in the client UI.
