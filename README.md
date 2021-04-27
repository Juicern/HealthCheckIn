# HealthCheckIn
本專案為2017級河海大學計算機專業《計算機課程綜合課程設計》專案。

需要文件的話可以email我，郵箱：qs4869@outlook.com。



## 功能



### 人員介面



啟動程式後進入登入介面

![](https://github.com/Juicern/HealthCheckIn/blob/main/image/Form-Login.png)

輸入賬號密碼後進入提交介面

![](./image/Form-Submit.png)

點選提交即可健康打卡



### 管理員介面



啟動程式後進入登入介面

![](./image/https://github.com/Juicern/HealthCheckIn/blob/main/image/Form-ManagerLogin.png)

登陸後進入管理介面，可檢視學生資訊和打卡資訊

![](./image/Form-Management.png)



## 錯誤提示



若賬號、密碼、體溫、健康、位置等資訊未輸入，則會彈窗報錯

![](https://github.com/Juicern/HealthCheckIn/blob/main/image/Form-InputError.png)



## 配置方法



因本專案使用了本地資料庫，因此需要現在本地搭建資料庫。

1. 下載sql server

2. 建立名為`HealthCheckIn`的資料庫

3. 資料庫中建立`personInfo`，`submitInfo`，`managerInfo`三張表

4. personInfo表：

   | 名稱     | 型別     | 是否可為null |
   | -------- | -------- | ------------ |
   | account  | nvarchar | 是           |
   | password | nvarchar | 是           |

   

5. submitInfo表：

   | 名稱        | 型別     | 是否可為null |
   | ----------- | -------- | ------------ |
   | account     | nvachar  | 是           |
   | time        | datetime | 是           |
   | temperature | int      | 是           |
   | health      | nvarchar | 是           |
   | location    | nvarchar | 是           |

6. managerInfo表：

   | 名稱     | 型別     | 是否可為null |
   | -------- | -------- | ------------ |
   | account  | nvarchar | 是           |
   | password | nvarchar | 是           |

7. 在程式碼的DataBaseHelper類中修改strConn，將server改為你的伺服器名
