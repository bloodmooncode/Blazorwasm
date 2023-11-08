<div align="center">
  <img src="./assets/logo.png" width="100" height="100" alt="LOGO">
  <h1>MicrogirdSync</h1>
</div>

<div align="center">
  <p>Energy management of microgrids</p>
</div>

<div align="center">

[![C#](https://img.shields.io/badge/C%23-10.0-orange?logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/) [![.NET Core 6.0](https://img.shields.io/badge/.NET%20Core-6.0-blue?logo=dot-net&logoColor=white)](https://dotnet.microsoft.com/download/dotnet/6.0) [![Blazor](https://img.shields.io/badge/Blazor-6.0-green?logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) [![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-red?logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server/)

</div>

You can choose between these two languages for the readme file:

- [中文](/README.md)
- [English](./README_en.md)

Our project is about building Web-based GUI software devdlopment for energy management of microgrids.

- [UI design](#ui-design)
- [Frontend](#frontend)
  - [Frontend Interface](#frontend-interface)
  - [Front-end Implementation](#front-end-implementation)
- [Backend](#backend)
  - [KeyWord Definition](#keyword-definition)
  - [Functional Requirement List](#functional-requirement-list)
  - [Back-end Functional Design Graph](#back-end-functional-design-graph)

## UI design

Use figma as the design tool for user interface, logo, spectial elements.. Just give some page blocks reference for frontend. Various component libraries are used in the actual front-end writing process like bootstrap, tailwindcss, ant-ui-design etc.

![Alt text](./assets/UI-design.png)

## Frontend

Use CSharp plus Blazor WebAssembly to finish the frontend of our project.

### Frontend Interface

![Alt text](./assets/interface-tree.png)

### Front-end Implementation

Some data are from Open Platform Communications Unified Architecture (OPC UA), object types define a set of common properties, methods, and events for objects. Object types act as templates for creating instances of objects with the same characteristics. The template is called Based Node Class, which has some characteristics showed below.

```
Mandatory Characteristics
1. Node Id
2. Display Name
3. Node Class
4. Browse Name

Optional Characteristics
1. Description
```

And Based Node derives these eight types, from which to combine as needed to present different structure microgrids.

![Alt text](./assets/opcua-structure.png)
Custom Information Model can be built based on OPC UA Base Information Model. Use TextEditor(Choose `VScode`) and Graphical Tools(Choose `UaModeler for mac`) to form XML file

See this XML example:
![Alt text](./assets/nodeset2-xml1.png)
![Alt text](./assets/nodeset2-xml2.png)
![Alt text](./assets/nodeset2-xml3.png)

## Backend

### KeyWord Definition

| 序号 | 名词      | 解释                     |
| ---- | --------- | ------------------------ |
| 1    | MicroGrid | 微型电力网络             |
| 2    | CDG       | 可控分布式发电机         |
| 3    | RDG       | 非可控可再生分布式发电机 |
| 4    | ESS       | 储能系统                 |
| 5    | SOC       | 储能系统（ESS）的储电量  |

### Functional Requirement List

| 序号 | 模块                 | 功能                            | 功能规则                                                                                                                                                                                                                                                                                                                                                              |
| ---- | -------------------- | ------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1    | 用户验证界面         | 用户注册                        | 用户注册时需要输入以下信息<br />1. 密码<br />2. 电子邮箱地址<br />用户的密码需要满足以下条件：<br />1. 长度为 6-20 位<br />2. 包含数字与字母                                                                                                                                                                                                                          |
| 2    |                      | 用户登录                        | 用户输入电子邮箱地址与密码，执行登录指令。                                                                                                                                                                                                                                                                                                                            |
| 3    |                      | 用户找回密码                    | 用户发出找回密码指令，系统发送验证码至用户电子邮件地址，由用户输入。如果核验成功，用户输入并确认新密码，否则退出流程。                                                                                                                                                                                                                                                |
| 4    | 微电网管理界面       | 用户添加 MicroGrid              | 用户添加 MicroGrid 时，需要输入如下属性：<br />1. MicroGrid 名称<br />2. Time Horizon<br />3. Interval<br />4.maximum buying power<br />5. minimum buying power<br />6. maximum selling power<br />7. minimum selling power                                                                                                                                           |
| 5    |                      | 用户删除 MicroGrid              | 用户删除没有任何组件的 MicroGrid 时，不提示，直接删除<br />否则，询问用户是否删除非空 MicroGrid，确认后删除                                                                                                                                                                                                                                                           |
| 6    |                      | 用户修改 MicroGrid 属性         |                                                                                                                                                                                                                                                                                                                                                                       |
| 7    |                      | 用户 MicroGrid 中添加 CDG       | 用户添加 CDG 时需输入如下属性：<br />1. CDG 名称<br />2. CDG 的 OPCUA 地址<br />3. cost model type<br />4. cost model parameters<br />5. Max Power(kW)<br />6. MinPower(kW)<br />7. R_Max Power(kW)                                                                                                                                                                   |
| 8    |                      | 用户 MicroGrid 中删除 CDG       | 用户删除时，询问用户，确认后删除                                                                                                                                                                                                                                                                                                                                      |
| 9    |                      | 用户修改 MicroGrid 中 CDG 属性  |                                                                                                                                                                                                                                                                                                                                                                       |
| 10   |                      | 用户 MicroGrid 中添加 RDG       | 用户添加 RDG 时，需要输入如下属性：<br />1. RDG 名称<br />2. RDG 种类                                                                                                                                                                                                                                                                                                 |
| 11   |                      | 用户 MicroGrid 中删除 RDG       | 用户删除时，询问用户，确认后删除                                                                                                                                                                                                                                                                                                                                      |
| 12   |                      | 用户修改 MicroGrid 中 RDG 属性  |                                                                                                                                                                                                                                                                                                                                                                       |
| 13   |                      | 用户 MicroGrid 中添加 ESS       | 用户添加 ESS 时，需要输入以下属性：<br />1. ESS 名称<br />2. ESS 种类<br />3. Max Charging Power(kW)<br />4. Min Charging Power(kW)<br />5. Max Discharging Power(kW)<br />6. Min Discharging Power(kW)<br />7. Energy Capacity(kWh)<br />8. Charging Efficiency(%)<br />9. Discharging Efficiency(%)<br />10. Max State of Charge(%)<br />11. Min State of Charge(%) |
| 14   |                      | 用户 MicroGrid 中删除 ESS       | 用户删除时，询问用户，确认后删除                                                                                                                                                                                                                                                                                                                                      |
| 15   |                      | 用户修改 MicroGrid 中 ESS 属性  |                                                                                                                                                                                                                                                                                                                                                                       |
| 16   |                      | 用户 MicroGrid 中添加 Load      | 用户添加 load 时需要输入以下属性：<br />1. Load 名称<br />2. Punish Parameter<br />3. Ratio of Non-critical Load(%)                                                                                                                                                                                                                                                   |
| 17   |                      | 用户 MicroGrid 中删除 Load      | 用户删除时，询问用户，确认后删除                                                                                                                                                                                                                                                                                                                                      |
| 18   |                      | 用户修改 MicroGrid 中 Load 属性 |                                                                                                                                                                                                                                                                                                                                                                       |
| 19   | 微电网可视化观察界面 | 电力价格图像绘制                | 网页绘制电力购买价格、电力出售价格的价格-时间图像                                                                                                                                                                                                                                                                                                                     |
| 20   |                      | 电力买卖功率图像绘制            | 网页绘制电力买卖功率-时间图像                                                                                                                                                                                                                                                                                                                                         |
| 21   |                      | CDG 状态图像绘制                | 网页绘制 CDG 的功率-时间图像                                                                                                                                                                                                                                                                                                                                          |
| 22   |                      | RDG 状态图像绘制                | 网页绘制 RDG 的功率-时间图像                                                                                                                                                                                                                                                                                                                                          |
| 23   |                      | ESS 状态图像绘制                | 网页绘制 ESS 的充放电功率-时间图像                                                                                                                                                                                                                                                                                                                                    |
| 24   |                      | Load 状态图像绘制               | 网页绘制 Load 的功率-时间图像                                                                                                                                                                                                                                                                                                                                         |
| 25   | 用户个人资料界面     | 用户退出登录                    |                                                                                                                                                                                                                                                                                                                                                                       |
| 26   |                      | 用户修改密码                    | 用户需要完成以下流程：<br />1. 输入原密码<br />2. 输入新密码<br />3. 确认新密码<br />当且仅当原密码匹配，新密码两次输入结果一致时，系统允许修改密码行为，否则系统拒绝修改密码行为。                                                                                                                                                                                   |
| 27   |                      | 用户重置密码                    | 用户点击重置密码，弹窗询问，用户确认以后，执行功能需求 3：用户找回密码的流程。                                                                                                                                                                                                                                                                                        |
| 28   |                      | 用户修改邮箱                    | 用户点击修改邮箱，系统向原电子邮箱地址发送验证码，用户输入验证码。如果核验成功，用户输入新的电子邮箱地址并提交，系统修改用户邮箱地址。                                                                                                                                                                                                                                |
| 29   |                      | 用户删除账户                    |                                                                                                                                                                                                                                                                                                                                                                       |
| 30   | 数据服务端           | 优化电力数据                    | 数据服务端读取微电网的数据，传递给优化器，从优化器读取优化结果，将优化结果传递给微电网<br />【更多细节等待完善】                                                                                                                                                                                                                                                      |
| 31   |                      | 连接微电网设备                  | 数据服务端使用 OPCUA 协议，访问微电网中各个组件的 OPCUA 地址，发送指令或者读取数据<br />【更多细节等待完善】                                                                                                                                                                                                                                                          |

### Back-end Functional Design Graph

![Alt text](./assets/database-tree.png)