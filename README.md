# Timely Elderly Fall Rescue Network

This is a project for DECO3500 - Social & Mobile Computing. It aims at sending timely rescue calls to volunteers when the elderly fall and facilitating volunteers to be instructed by medical staff remotely before they arrive.

Presented by **Hyperdash**.

## Poster (Promotional Material)
![DECO3500_Poster](https://user-images.githubusercontent.com/31987631/138314194-482e7e12-80cb-4d09-93e5-fee0992f7fa2.png)

You can also check people's comments,questions and our response on this [Miro board](https://miro.com/app/board/o9J_lqrpMvI=/)

## Working Prototype
There are two parts of our final prototype, app UI implemented by Figma and userflow simulation implemented by Unity.

Figma prototype shows the full volunteer side UI. Elderly and medical side UI, core features userflow are shown in the Unity scene.

- Experience our prototype [here](https://www.figma.com/proto/G5MCQeT6e8d0DnKPXVCqQG/3500-High-fidelity-prototype?node-id=3%3A2&scaling=scale-down&page-id=0%3A1&starting-point-node-id=3%3A2&show-proto-sidebar=1)
<img width="600" alt="Prototype" src="https://user-images.githubusercontent.com/31987631/138312577-281bfae6-7cff-4935-bd14-9f5810d679a3.png">

- Experience our userflow simulation in a Unity scene [here](https://recklesspotcover.github.io/DECO3500-Project/)
<img width="600" alt="Unity Scene" src="https://user-images.githubusercontent.com/31987631/138313003-63bf17bd-3157-410a-aec6-60b4755f234c.png">

*This is a WebGL build hosted on GitHub page. Use Google Chrome or Firefox for the best experience. Fullscreen mode is not recommended since there are UI and performance issue*

And we are open for anyone to build upon our project:
- To view our Figma project file [here](https://www.figma.com/file/G5MCQeT6e8d0DnKPXVCqQG/3500-High-fidelity-prototype?node-id=0%3A1)
- Our Unity project folder is also available, download it [here](https://drive.google.com/file/d/1UcphixTqav-gnN34lBA_Rwgm_qjmjX1P/view?usp=sharing)

For Unity project, these platforms have the best compatibility:
- Unity Hub version: ***3.0.0-beta.5***
- Unity Editor version: ***2020.3.15f2***
- Visual Studio for Mac: ***8.10.11*** (Open on Windows or Linux may generate warnings, but they can be easily fixed)

To work on the Unity project:
1. After the download, select ***"Add project from disk"*** in Unity Hub
2. Select the project folder
3. Click ***"open"***
4. You are good to go!

## Summary
### Problem Space
### Design Opportunity
### Our Solution
在老人、志愿者和医疗人员建立网络，让志愿者作为医疗人员能力的延伸，尽可能及时的让老人接受到尽可能专业的救助
## Designing and Prototyping Process (Process)
从conceptual design到最终的原型经历了research验证，原型制作及两轮迭代，详细如下
### Litrature Research
把你们 research 的几个 part 的结论总结一下
说一下 concept design  我们想做一个能在老人跌倒孤立无援时为其提供帮助的网络
### Survey
1. 调查老人的需求 -> 老人有需求
2. 调查潜在志愿者的意愿 -> 大部分都愿意
### Low Fedility Prototype
专注于方便志愿者的救助流程和日常急救知识学习
### Heuristic Evaluation
Process
Result
####Changes
1. 说一下志愿者端的短处(入户过程不够流畅。界面交互逻辑问题，说严重的)
2. 有增加老人端（优先级）的必要
### Medium Fedility Prototype
我们增加了什么功能去迎合上面两个需求
### Medium Fedility Prototype Evaluation
#### Think Aloud & Time of Task
Process
Result
#### Blablabla
Process
Result
#### Changes
1.志愿者端仍存在的问题（界面交互逻辑问题）
2.老人端的问题（加上地址语音录入）
3.医疗端的缺失 
### High Fedility Prototype & Unity Userflow Simulation
#### Hi-Fi Prototype
上面说的俩问题
加入了医疗端（本来只是志愿者会打来视频通话，现在是医疗端有独享的界面接收救援提醒、查看生命体征和获取密码）
#### Unity
为了让用户对原型有更好地了解，制作Unity场景使用户能以3种不同身份体验同一个救援过程，展现Figma无法诠释的交互，比如验证志愿者/医疗人员位置或门锁解开自动跳转页面
### Future Direction
修复残存问题
1. 美观方面的
2. 跌倒的严重等级分类
进步方向
1. 更 friendly/silently 的检测系统，而不是使用手表

## Team Role
| Member Name | Role |
| ---- | ---- |
| Jiacheng(Alex) Ni | Leader (Hi-Fi), Designer, Developer (Unity) |
| Zewei(Eric) Zhu | Designer |
| He(Gavin) Zhu | Designer, Developer (Unity) |
| Yingxin(Evelyn) Liu | Leader (Med), Designer |
| Zhenyu(Evan) Ding | Leader (Lo-Fi), Designer |
| Kai(Daniel) Wang | Minute-taker, Designer |
