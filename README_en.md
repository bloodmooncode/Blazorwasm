<div align="center">
  <img src="./assets/logo.png" width="100" height="100" alt="LOGO">
  <h1>MicrogirdEMS</h1>
</div>

<div align="center">
  <p>Energy management of microgrids</p>
</div>

<div align="center">

[![C#](https://img.shields.io/badge/C%23-10.0-orange?logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/) [![.NET Core 6.0](https://img.shields.io/badge/.NET%20Core-6.0-blue?logo=dot-net&logoColor=white)](https://dotnet.microsoft.com/download/dotnet/6.0) [![Blazor](https://img.shields.io/badge/Blazor-6.0-green?logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) [![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-red?logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server/)

</div>

You can choose either of the two languages to read the `readme` document:

- [Chinese](/README.md)
- [English](./README_en.md)

This project is aimed at developing a web-based GUI software for energy management of microgrids. Frontend development tool `vscode`, backend development tool `IDEA`

- [UI Design](#ui-design)
- [Frontend Related](#frontend-related)
  - [Frontend Interface Design](#frontend-interface-design)
  - [Frontend Preview](#frontend-preview)
  - [Running the Frontend](#running-the-frontend)
- [Backend Related](#backend-related)
  - [Keyword Definitions](#keyword-definitions)
  - [](#)
  - [Backend Function Interface Design](#backend-function-interface-design)
  - [Backend Implementation](#backend-implementation)
- [opcua Data Interaction](#opcua-data-interaction)

## UI Design
Designed UI interface using `figma`, only implemented basic wireframe layout.

![Alt text](./assets/UI-design.png)

## Frontend Related

Using `CSharp` and `Blazor WebAssembly` template to accomplish the frontend logic of the project.

Various component libraries were experimented with during actual frontend coding, such as [bootstrap V5](https://getbootstrap.com/docs/5.3/getting-started/introduction/)
, [MudBlazor](https://mudblazor.com/docs/overview)

### Frontend Interface Design

![Alt text](./assets/interface-tree.png)

### Frontend Preview
![Alt text](./assets/frontend-preview.png)

### Running the Frontend
```bash
dotnet watch run  # support hot reload
# port: 5277
```


## Backend Related
### Keyword Definitions
| No.  | Term      | Definition                                     |
| ---- | --------- | ---------------------------------------------- |
| 1    | MicroGrid | Micro Power Grid                               |
| 2    | CDG       | Controllable Distributed Generator             |
| 3    | RDG       | Uncontrollable Renewable Distributed Generator |
| 4    | ESS       | Energy Storage System                          |
| 5    | SOC       | State of Charge (for ESS)                      |

### 

### Backend Function Interface Design
![Alt text](./assets/database-tree.png)

### Backend Implementation
Backend testing environment set up with `springboot` + `MySQL`,
[Testing Backend Code Repository](https://github.com/bloodmooncode/bwa-backend)

[API JSON Collection](./Docs/bwa-api.postman_collection.json) can be imported into Postman for API interface testing

## opcua Data Interaction

[opcua server data](./Docs/opcua.md) remains unimplemented.