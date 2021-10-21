# Timely Elderly Fall Rescue Network

This is a project for DECO3500 - Social & Mobile Computing. It aims at sending timely rescue calls to volunteers when the elderly fall and facilitating volunteers to be instructed by medical staff remotely before they arrive.
## Poster (Promotional Material)

You can check our promotional poster on this [Miro board](https://miro.com/app/board/o9J_lqrpMvI=/)

## Summary
This is a summary of the workflow of our group. The specific process is as follows.

### Problem Space
#### Living Alone
- Those elderly living alone may not get a rescue in time when accidents happen.

- Increasing in the number of elderly people living alone: Elderly people do not want to be a burden to their families, people are less likely to continue living with their parents after they get married.
#### Severity
- Falls are the leading cause of fatal injuries: Every 11 seconds, an elderly person is brought to the emergency room because of a fall. Every 19 minutes, an elderly person dies as a result of a fall.

### Design Opportunity
- It is difficult to detect accidents in elderly people who live alone.

- Elderly people living in rural areas often spend more time waiting for help.

- As the rescue time grows, the probability of the elderly having an accident also increases dramatically.

### Our Solution
Establish a network between the elderly, the volunteers and the medical staff, so that the volunteers can act as an extension of the medical staff's capacity to provide the elderly with the most timely and professional assistance possible.
## Designing and Prototyping Process 
From the conceptual design to the final prototype has gone through research verification, prototyping and two rounds of iterations, as detailed below.
### Litrature Research
#### Part 1: Domain Research
A device is needed to monitor the physical and mental health of elderly people living alone in real time and to minimize rescue time.
#### Part 2: Volunteer Motivation Survey
It is necessary to observe the changes in volunteers' mindset before they choose to join the volunteer team, during their work in the volunteer team, and when they choose to leave the volunteer team. In addition, the sensitivity of volunteers to money is also important to explore.
#### Part 3: Survey on the willingness of the elderly
Before providing assistance, it is important to find out if the elderly need assistance. What kind of assistance they need and who they would prefer to be helped by.
#### Part 4: Existing solutions
Although there are now a variety of fall detection devices on the market, but there are still a range of problems such as limited detection range, insensitive edge detection or errors in the detection results due to the difference between the production material and human skin tissue.
#### Concept Design  
Our design is set to provide assistance for first aid volunteers in order to provide professional and in-time rescue to the elderly living alone.

The specific Litrature Research & Concept Design is available on the wiki page. [here](https://github.com/RecklessPotcover/DECO3500-Project/wiki/Literature-Research)
### Survey
#### Survey the needs of the elderly 
The elderly prefer to choose family and friends as first responders. The elderly have the need to be rescued.
####Survey the willingness of potential volunteers 
Most of the survey participants are willing to give help to the elderly.

The specific Survey is available on the wiki page. [here](https://github.com/RecklessPotcover/DECO3500-Project/wiki/Interview-and-Interview-Analysis)
### Low Fedility Prototype
Our low-fidelity model is focused on facilitating the rescue process and daily first aid learning for volunteers.
### Heuristic Evaluation
We chose the illumination assessment as our low-fidelity assessment method.
#### Process
Users will provide comments on our low-fidelity model based on 10 areas of questions.
#### Result
We invited 6 evaluators and gained 18 valuable revised opinions.
#### Changes
We have listed the changes we are going to make in our mid-fidelity prototype.
##### Shortcomings of the volunteer side
- The process of entering the home is not smooth enough. 

- Lack of return key.

- Lack of constraint requirement on the username and password setting.

##### The need to increase the elderly side
- Lack of ability for seniors to select rescue priority.

The specific Survey is available on the wiki page. [here](https://github.com/RecklessPotcover/DECO3500-Project/wiki/Low-Fidelity-Prototype)
### Medium Fedility Prototype
We made plenty of changes based on the feedback of the Low Fedility Prototype evaluations, some changes include adding “go back” buttons, adding a constraint requirement on the username and password setting. And the design of the elderly side, the elderly or elderly family members can set the priority of rescue.
### Medium Fedility Prototype Evaluation
The evaluation process includes templates for the three evaluation methods, the test results and the conclusions obtained by the evaluation process.
#### Think Aloud & Time-on-Task
We used these two evaluation methods to obtain data for the evaluation process.
###### Process
We used the Time-on-Task evaluation method to observe the time users spent on each page of our mid-fidelity prototype, and the Think aloud evaluation method to record user comments during the evaluation process.
###### Result
- Since each evaluator has a different focus, they spend different amounts of time in different interfaces.

- We collected 8 usability recommendations through the Think Aloud evaluation method.
#### The Cognitive Walkthrough Evaluation
##### Process
1. Define inputs to the walkthrough
2. Convene the walkthrough
3. Walkthrough the action sequences for each task
4. Record critical information
5. Revise the interface to fix the problems
###### Result
18 evaluators were involved in the entire evaluation process. 10 valuable revised opinions were come up with.
#### Changes
We have listed the changes we are going to make in our high-fidelity prototype.
##### Problems still exist on the volunteer side
- User interface interaction is not smooth enough.
##### Missing functions on the elderly side
- Lack of address voice entry function.
##### The medical side is missing
- Lack of specific functions for the medical side.

The specific Survey is available on the wiki page. [here](https://github.com/RecklessPotcover/DECO3500-Project/wiki/Medium-Fidelity-Prototype)
### High Fedility Prototype & Unity Userflow Simulation
We use Unity to design our high-fidelity models.
#### Hi-Fi Prototype
We fixed the volunteer interface interaction and the Lack of address voice entry on the elderly side in the high fidelity prototype. In addition, we also designed the medical side. Previously, the medical side would only receive video calls from volunteers, but now the medical side has an exclusive interface to receive rescue alerts, check vitals and get passwords.
#### Unity
To give the user a better understanding of the prototype, Unity scenes were created so that the user could experience the same rescue process in three different capacities, showing interactions that Figma could not interpret, such as verifying the location of the volunteer/medical staff or the automatic page jump when the door is unlocked.

The specific Survey is available on the wiki page. [here](https://github.com/RecklessPotcover/DECO3500-Project/wiki/High-Fidelity-Prototype)
### Future Direction
Fix the remaining problems
- interface aesthetics problem.
- Lack of classification of the severity level of falls.
Direction of progress
- Design a more friendly/silently detection system instead of using a watch to detect elderly falls.

## Poster (Promotional Material)

## Try it! (Prototype)
There are two parts of our final prototype, mobile app user interface with Figma and userflow simulation with Unity.

Experience our Figma project file [here](https://www.figma.com/file/G5MCQeT6e8d0DnKPXVCqQG/3500-High-fidelity-prototype?node-id=0%3A1)

Check our full volunteer side UI [here](https://www.figma.com/proto/G5MCQeT6e8d0DnKPXVCqQG/3500-High-fidelity-prototype?node-id=3%3A2&scaling=scale-down&page-id=0%3A1&starting-point-node-id=3%3A2&show-proto-sidebar=1)

Experience our userflow simulation in a "Game" [here](https://recklesspotcover.github.io/DECO3500-Project/)

*Our core features, elderly and medical side UI are shown in this game. Use Google Chrome or Firefox for the best experience. Fullscreen mode is not recommended since there are UI and performance issue*

The unity project folder is also available, download it [here](https://drive.google.com/file/d/1UcphixTqav-gnN34lBA_Rwgm_qjmjX1P/view?usp=sharing)


## Build upon it!

You can download our Unity project folder [here](https://drive.google.com/file/d/1UcphixTqav-gnN34lBA_Rwgm_qjmjX1P/view?usp=sharing)

Following platforms have best compatibility:

- Unity Hub: ***3.0.0-beta.5***
- Unity Editor: ***2020.3.15f2***
- Visual Studio for Mac: ***8.10.11*** (May get warnings when open with Windows version, but they can be easily fixed)

1. Download the [Unity project folder](https://drive.google.com/file/d/1UcphixTqav-gnN34lBA_Rwgm_qjmjX1P/view?usp=sharing), select **"Add project from disk"** in Unity Hub
2. Select the repository folder
3. Click **"open"**
4. Enjoy!

