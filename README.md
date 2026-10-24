# Feedback Management Module

Practical 7 — .NET Technologies

**Aim:** Develop Feedback Management Module using MVC Layout, Partial View & Validation (HTML Helpers, Validation, Layouts).

## Features
- Student feedback form
- Model validation with data annotations
- Feedback list page
- Shared MVC layout and partial navigation
- In-memory storage for demonstration (feedback resets when the app restarts)

## Important platform note
This source follows the classic ASP.NET MVC 5 / `System.Web.Mvc` style shown in the lab PDF. Classic ASP.NET MVC 5 requires the .NET Framework and is not natively runnable on macOS. You can still keep this source in GitHub from Mac Terminal. To run the classic MVC 5 app, use a compatible Windows + Visual Studio/.NET Framework setup. Alternatively, it can be ported to ASP.NET Core MVC for native macOS development.

## Suggested MVC 5 placement
Copy these files into a classic ASP.NET MVC 5 project, keeping the folders and namespace `feedback1`:
- `Controllers/feedbackController.cs`
- `Models/Feedback.cs`
- `Views/Feedback/Index.cshtml`
- `Views/Feedback/Create.cshtml`
- `Views/Feedback/ViewFeedback.cshtml`
- `Views/Shared/_Layout.cshtml`
- `Views/Shared/_Navigation.cshtml`

The controller name is `feedbackController` to match the PDF. MVC convention normally uses `FeedbackController`; if you rename it, update view links consistently.
