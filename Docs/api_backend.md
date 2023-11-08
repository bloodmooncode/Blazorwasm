# NUS-EMS 服务端 API 文档

- [NUS-EMS 服务端 API 文档](#nus-ems-服务端-api-文档)
  - [\<baseurl\>/api/user/signup](#baseurlapiusersignup)
    - [类型](#类型)
    - [参数](#参数)
    - [返回值](#返回值)
  - [\<baseurl\>/api/user/login](#baseurlapiuserlogin)
    - [类型](#类型-1)
    - [参数](#参数-1)
    - [返回值](#返回值-1)
  - [\<baseurl\>/api/user/resetpassword](#baseurlapiuserresetpassword)
    - [类型](#类型-2)
    - [参数](#参数-2)
    - [返回值](#返回值-2)
  - [\<baseurl\>/api/user/delete](#baseurlapiuserdelete)
    - [类型](#类型-3)
    - [参数](#参数-3)
    - [返回值](#返回值-3)
  - [\<baseurl\>/api/microgrid/add](#baseurlapimicrogridadd)
    - [类型](#类型-4)
    - [参数](#参数-4)
    - [返回值](#返回值-4)
  - [\<baseurl\>/api/microgrid/set](#baseurlapimicrogridset)
    - [类型](#类型-5)
    - [参数](#参数-5)
    - [返回值](#返回值-5)
  - [\<baseurl\>/api/microgrid/delete](#baseurlapimicrogriddelete)
    - [类型](#类型-6)
    - [参数](#参数-6)
    - [返回值](#返回值-6)
  - [\<baseurl\>/api/microgrid/get](#baseurlapimicrogridget)
    - [类型](#类型-7)
    - [参数](#参数-7)
    - [返回值](#返回值-7)
  - [\<baseurl\>/api/deviceinfo/add](#baseurlapideviceinfoadd)
    - [类型](#类型-8)
    - [参数](#参数-8)
    - [返回值](#返回值-8)
  - [\<baseurl\>/api/deviceinfo/set](#baseurlapideviceinfoset)
    - [类型](#类型-9)
    - [参数](#参数-9)
    - [返回值](#返回值-9)
  - [\<baseurl\>/api/deviceinfo/delete](#baseurlapideviceinfodelete)
    - [类型](#类型-10)
    - [参数](#参数-10)
    - [返回值](#返回值-10)
  - [\<baseurl\>/api/deviceinfo/get](#baseurlapideviceinfoget)
    - [类型](#类型-11)
    - [参数](#参数-11)
    - [返回值](#返回值-11)
  - [\<baseurl\>/api/date/get](#baseurlapidateget)
    - [类型](#类型-12)
    - [参数](#参数-12)
    - [返回值](#返回值-12)

注：类型包括新建、修正、增加、删除。

## \<baseurl\>/api/user/signup

### 类型

POST

### 参数

| 序号 | 参数名 | 参数类型               | 描述                                                 |
| ---- | ------ | ---------------------- | ---------------------------------------------------- |
| 1    | info   | UserAuthenticationInfo | 用户的认证信息，包括电子邮箱和密码。                 |
| 2    | nonce  | int                    | 一次性验证码。如果为 0，系统会向邮箱地址发送验证码。 |

### 返回值

无

## \<baseurl\>/api/user/login

### 类型

POST

### 参数

| 序号 | 参数名 | 参数类型               | 描述                                 |
| ---- | ------ | ---------------------- | ------------------------------------ |
| 1    | info   | UserAuthenticationInfo | 用户的认证信息，包括电子邮箱和密码。 |

### 返回值

| 名称  | 类型   | 描述                               |
| ----- | ------ | ---------------------------------- |
| token | string | 用户身份令牌，用于认证用户的身份。 |

## \<baseurl\>/api/user/resetpassword

### 类型

POST

### 参数

| 序号 | 参数名   | 参数类型     | 描述                                                 |
| ---- | -------- | ------------ | ---------------------------------------------------- |
| 1    | token    | string       | 用户身份令牌，用于认证用户的身份。                   |
| 2    | nonce    | int          | 一次性验证码。如果为 0，系统会向邮箱地址发送验证码。 |
| 3    | password | SecureString | 用户的密码。                                         |

### 返回值

无

## \<baseurl\>/api/user/delete

### 类型

POST

### 参数

| 序号 | 参数名 | 参数类型 | 描述                                                 |
| ---- | ------ | -------- | ---------------------------------------------------- |
| 1    | token  | string   | 用户身份令牌，用于认证用户的身份。                   |
| 2    | nonce  | int      | 一次性验证码。如果为 0，系统会向邮箱地址发送验证码。 |

### 返回值

无

## \<baseurl\>/api/microgrid/add

### 类型

POST

### 参数

| 序号 | 参数名 | 参数类型      | 描述                               |
| ---- | ------ | ------------- | ---------------------------------- |
| 1    | token  | string        | 用户身份令牌，用于认证用户的身份。 |
| 2    | info   | MicrogridInfo | 电网信息。                         |

### 返回值

无

## \<baseurl\>/api/microgrid/set

### 类型

POST

### 参数

| 序号 | 参数名 | 参数类型      | 描述                               |
| ---- | ------ | ------------- | ---------------------------------- |
| 1    | token  | string        | 用户身份令牌，用于认证用户的身份。 |
| 2    | info   | MicrogridInfo | 电网信息。                         |

### 返回值

无

## \<baseurl\>/api/microgrid/delete

### 类型

POST

### 参数

| 序号 | 参数名 | 参数类型 | 描述                               |
| ---- | ------ | -------- | ---------------------------------- |
| 1    | token  | string   | 用户身份令牌，用于认证用户的身份。 |
| 2    | id     | int      | 电网 ID。                          |

### 返回值

无

## \<baseurl\>/api/microgrid/get

### 类型

GET

### 参数

| 序号 | 参数名 | 参数类型        | 描述                               |
| ---- | ------ | --------------- | ---------------------------------- |
| 1    | token  | string          | 用户身份令牌，用于认证用户的身份。 |
| 2    | filter | MicrogridFilter | 电网信息筛选条件。                 |

### 返回值

| 名称     | 类型                  | 描述                     |
| -------- | --------------------- | ------------------------ |
| infoList | List\<MicrogridInfo\> | 符合条件的电网信息列表。 |

## \<baseurl\>/api/deviceinfo/add

### 类型

POST

### 参数

| 序号 | 参数名 | 参数类型   | 描述                               |
| ---- | ------ | ---------- | ---------------------------------- |
| 1    | token  | string     | 用户身份令牌，用于认证用户的身份。 |
| 2    | info   | DeviceInfo | 设备信息。                         |

### 返回值

无

## \<baseurl\>/api/deviceinfo/set

### 类型

POST

### 参数

| 序号 | 参数名 | 参数类型   | 描述                               |
| ---- | ------ | ---------- | ---------------------------------- |
| 1    | token  | string     | 用户身份令牌，用于认证用户的身份。 |
| 2    | info   | DeviceInfo | 设备信息。                         |

### 返回值

无

## \<baseurl\>/api/deviceinfo/delete

### 类型

POST

### 参数

| 序号 | 参数名 | 参数类型   | 描述                               |
| ---- | ------ | ---------- | ---------------------------------- |
| 1    | token  | string     | 用户身份令牌，用于认证用户的身份。 |
| 2    | info   | DeviceInfo | 设备信息。                         |

### 返回值

无

## \<baseurl\>/api/deviceinfo/get

### 类型

GET

### 参数

| 序号 | 参数名 | 参数类型     | 描述                               |
| ---- | ------ | ------------ | ---------------------------------- |
| 1    | token  | string       | 用户身份令牌，用于认证用户的身份。 |
| 2    | filter | DeviceFilter | 设备信息筛选条件。                 |

### 返回值

| 名称     | 类型               | 描述                     |
| -------- | ------------------ | ------------------------ |
| infoList | List\<DeviceInfo\> | 符合条件的设备信息列表。 |

## \<baseurl\>/api/date/get

### 类型

GET

### 参数

| 序号 | 参数名 | 参数类型   | 描述                               |
| ---- | ------ | ---------- | ---------------------------------- |
| 1    | token  | string     | 用户身份令牌，用于认证用户的身份。 |
| 2    | filter | DataFilter | 数据筛选条件。                     |

### 返回值

| 名称     | 类型                 | 描述                 |
| -------- | -------------------- | -------------------- |
| dataList | List\<RealtimeData\> | 符合条件的数据列表。 |
