# WorkoutPlanner-ISS

				Team Neoisis Requirements

	-All pages will feature a navbar with buttons that will shift between the different pages available.

I.	Calendar

-top of the calendar will feature the currently selected month (default: current month), with two arrow buttons that will shift the calendar one month (forwards/backwards).
-top of the calendar will likewise feature the currently selected year (default: current year). 
-displays days in the form of cells under a boxed layout, where each column represents a certain day of the week (i.e. Monday, Tuesday…) and each row represents a certain week (i.e week1, week2…) of the month.
-cells in the calendar will be color-coded accordingly: 
	* days with missed workouts: red
	* days with completed workouts: green
	* days with added, yet still uncompleted (future) workouts: yellow
-cells in the calendar will include a letter (C/W respectively) depending on the type of activity assigned to the day (or both).
-clicking a cell in the calendar will open a window with details about a specific day. If that day already has a workout/class assigned, this page will offer more details about them and also give the user the opportunity to edit/delete them from that specific day. If that day does -not- have an activity assigned, the user will be able to assign an activity to that day (workout, class). !! THE OPERATIONS OF ADDING ACTIVITIES TO A SPECIFIC DAY AND EDITING/DELETING ACTIVITIES FROM A SPECIFIC DAY CAN ONLY BE DONE ON PRESENT DAY OR THE FOLLOWING DAYS (no already passed days)!!

II.	Main Page
-will display an image on the left side of the page, showing a human body with each muscle group assigned for the day’s workout with a color.
-the right side of the page will show today’s workout in detail, with each assigned exercise (with name, sets, reps). If the current date does not have a current workout, it will instead have a button that will link towards the workout page, allowing the user to create/load a workout for the day.
III.	Classes Page
-display all classes in the form of cards with name and a register button. When the user presses the register button, a window with an input field will pop up, allowing the user to choose the date in which to attend the class ( date must be present or future).
-user will be able to search classes by name through a searchbar, filter the classes by class type and personal trainer.
IV.	Workouts Page
-displays already saved workouts in the form of cards with name, workout description ( a list with exercises and their details), targeted muscle groups, edit button, workout difficulty.
-clicking on a workout card will open a popup window showing the details of the workout (i.e. showing all exercises in the workout, with sets and reps)
-allows user to add a new workout through an add button which will open a new window allowing the user to select exercises to add to a new workout, with editable sets and reps. The new window will feature two lists, a list with the current workout and another list with all available exercises. A “+” button next to the exercises in the list allows the user to add the exercise to the workout. A “-“…
-a searchbar will allow the user to search workouts by name, a filter button will allow users to filter workouts by trained muscle groups and difficulty.  

V.	Rankings Page
-will display an image on the left side of the page, showing a human body with each muscle group, color-coded based on rank .Clicking one of the muscle groups will show information on the right side. When no muscle group is selected, the right side will instead show information about all ranks (their points brackets, badges and names).
-the information on the right will detail: the rank name, a suggestive icon, current ranking points for said muscle group in paranthesis. Below, there will be a progress bar showing progress towards the next rank, a statistic showing the number of exercises completed for this muscle group this month, as well as sets and reps.
VI.	Database Creation
1.	Users
o	UID (Primary Key)
2.	UserClasses
o	UID (Foreign Key referencing Users.UID)
o	CID (Foreign Key referencing Classes.CID)
o	EnrollmentDate
3.	Classes
o	CID (Primary Key)
o	Name
o	Description
o	CTID (Foreign Key referencing ClassTypes.CTID)
o	PTID (Foreign Key referencing PersonalTrainers.PTID)
4.	ClassTypes
o	CTID (Primary Key)
o	Name
5.	PersonalTrainers
o	PTID (Primary Key)
o	LastName
o	FirstName
o	WorkSince
6.	UserWorkouts
o	UWID (Primary Key)
o	UID (Foreign Key referencing Users.UID)
o	WID (Foreign Key referencing Workouts.WID)
o	Date
7.	Workouts
o	WID (Primary Key)
o	Name
o	WTID (Foreign Key referencing WorkoutTypes.WTID)
8.	WorkoutTypes
o	WTID (Primary Key)
o	Name
9.	Exercises
o	EID (Primary Key)
o	MGID (Foreign Key referencing MuscleGroups.MGID)
o	Name
o	Description
o	Difficulty
10.	CompleteWorkouts
•	WID (Foreign Key referencing Workouts.WID)
•	EID (Foreign Key referencing Exercises.EID)
•	Sets
•	RepsPerSet
11.	MuscleGroups
•	MGID (Primary Key)
•	Name
12.	Rankings
•	UID (Foreign Key referencing Users.UID)
•	MGID (Foreign Key referencing MuscleGroups.MGID)
•	Rank

