# HighScore

**HighScore** is a comprehensive platform that provides detailed information and user-based evaluations about games for gaming enthusiasts. This project aims to help users make informed decisions about games by offering a wide range of details, such as which platforms the games have been released on, their release dates, categories, the game's storyline, and trailer videos. Users can rate games and leave reviews on this platform.

## About the Project

### Purpose

HighScore aims to create an environment where gaming enthusiasts can come together to share their thoughts about games, gain insights into various features of games, and form opinions about the quality of games through a community-driven rating system. The platform encourages users to make objective evaluations about games while providing detailed information about the content and features of the games, enabling gamers to make informed choices.

### Features

#### Game Information
HighScore offers its users the following details about games:
- **Platform Information:** Indicates which platforms the games have been released on or will be released on.
- **Release Dates:** Includes the release dates of the games.
- **Categories:** Lists the categories or genres the games belong to.
- **Game Storyline:** Provides information about the storyline or theme of the gameplay.
- **Trailer Videos:** Offers promotional videos of the games, allowing users to gain a visual understanding of the game.

#### Rating and Review System
HighScore allows users to rate and review games:
- **Rating:** Users can rate games on a scale of 0 to 100, allowing the community to see how games are generally evaluated.
- **Reviews:** Users can write detailed reviews about games and have the ability to edit or delete their reviews. Reviews are visible to other users and can be assessed by the community.

#### Admin Panel (Admin Features)
HighScore provides extensive permissions to admin users:
- **Game Management:** Admin users can add new games to the platform, edit existing games, and delete them if necessary.
- **User Management:** Admins can ban, delete, or add new users who do not comply with the rules. They can also create new roles for users and assign these roles accordingly.
- **Review Management:** Admins can remove comments from the platform that do not adhere to the rules or community standards.

#### User Roles
There are two main user roles in HighScore:
- **Standard Users:** They can browse games, write reviews about games, and rate them. They also have the ability to edit or delete their own reviews.
- **Admin Users:** They have broader permissions and are responsible for managing the content and users on the platform.

## Technologies Used

HighScore is developed using modern web development technologies:

- **Frontend Technologies:**
  - **HTML5:** For structuring web pages.
  - **CSS3:** For defining the visual design and style of the pages.
  - **JavaScript:** To provide interactive and dynamic user experiences.
  - **jQuery:** To simplify JavaScript tasks and manage AJAX operations.
  - **Bootstrap 5:** To create a mobile-responsive and modern user interface.

- **Backend Technologies:**
  - **ASP.NET Core 8:** To provide the foundational infrastructure and handle server-side operations.
  - **MySQL:** For database management and data storage.
  - **ASP.NET Identity:** For managing user authentication and authorization.

- **Architecture:** The project follows the MVC (Model-View-Controller) pattern and utilizes a 3-layer architecture, ensuring the code is more manageable, testable, and scalable.

## Installation and Usage

To run the HighScore platform on your local environment, follow these steps:

### 1. Clone the Project
First, clone the project from the GitHub repository to your local machine:
```bash
git clone https://github.com/omertamgac/HighScore.git
```

### 2. Install Dependencies
Navigate to the root directory of the project and run the following command to install the required dependencies:
```bash
dotnet restore
```

### 3. Database Configuration
Set up your MySQL database and add the connection string to the `appsettings.json` file. Apply the database migrations by running:
```bash
dotnet ef database update
```

### 4. Running the Application
To run the project, use the following command:
```bash
dotnet run
```
This command will start the application on your local server, and you can view the project in your browser.

## Contributing

If you would like to contribute to the HighScore project, feel free to open an `issue` or submit a `pull request` on GitHub. Any feedback and contributions are welcome and will help the project improve.

## License

This project is licensed under the MIT License. For more information, please refer to the `LICENSE` file.

--- 

This description is professional and comprehensive, giving potential contributors and users a clear understanding of the project's goals, features, and technologies used.
