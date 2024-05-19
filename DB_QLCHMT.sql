﻿CREATE DATABASE CuaHangMayTinh
GO
USE CuaHangMayTinh
GO


CREATE TABLE BRAND(
	BRD_ID VARCHAR(100) PRIMARY KEY,
	BRD_NAME NVARCHAR(255) NOT NULL,
	BRD_ADDRESS NVARCHAR(255),
	BRD_PHONE VARCHAR(15),
	BRD_EMAIL VARCHAR(100),
	BRD_STATUS NVARCHAR(255) --Trạng thái (Đang hợp tác, dừng hợp tác...)
);
GO
ALTER TABLE BRAND
ALTER COLUMN BRD_ADDRESS NVARCHAR(255);

CREATE TABLE POSITION(
	PS_ID VARCHAR(100) PRIMARY KEY,
	PS_NAME NVARCHAR(255) NOT NULL,
	PS_NOTE NVARCHAR(255),
)
GO

CREATE TABLE AUTHORITY(
	AUT_ID VARCHAR(100) PRIMARY KEY,
	AUT_NAME NVARCHAR(255) NOT NULL
)
GO

CREATE TABLE POSITION_AUTHORITY(
	ID VARCHAR(100) PRIMARY KEY,
	PS_ID VARCHAR(100) FOREIGN KEY REFERENCES POSITION(PS_ID),
    AUT_ID VARCHAR(100) FOREIGN KEY REFERENCES AUTHORITY(AUT_ID),
	ROLE_TYPE NVARCHAR(50) --'Đọc và ghi','Chỉ đọc', 'Không có quyền'
)
GO

CREATE TABLE EMPLOYEES(
	EMP_ID VARCHAR(100) PRIMARY KEY,
	EMP_NAME NVARCHAR(255) NOT NULL,
	EMP_PHONE_NUMBER VARCHAR(10) NOT NULL,
	EMP_BIRTHDAY DATE NOT NULL,
	EMP_GENDER NVARCHAR(3),
	EMP_PROVINCE NVARCHAR(255),
	EMP_DISTRICT NVARCHAR(255), 
	EMP_WARD NVARCHAR(255),
	EMP_ADDRESS NVARCHAR(255) NOT NULL,
	EMP_EMAIL VARCHAR(100) NOT NULL,
	EMP_ACCOUNT VARCHAR(20) NOT NULL,
	EMP_PASSWORD VARCHAR(20) NOT NULL,
	HIRE_DATE DATETIME,
	PS_ID VARCHAR(100) FOREIGN KEY REFERENCES POSITION(PS_ID),
	EMP_STATUS NVARCHAR(255),
);
GO

CREATE TABLE CUSTOMER (
    CUS_ID VARCHAR(100) PRIMARY KEY,
    CUS_NAME NVARCHAR(255) NOT NULL,
	CUS_BIRTHDAY DATE,
	CUS_GENDER NVARCHAR(3),
	CUS_PHONE_NUMBER VARCHAR(10) NOT NULL,
    CUS_ADDRESS NVARCHAR(255) NOT NULL,
	CUS_TOTAL_SPENDING_MONEY INT,
	CUS_TOTAL_PRODUCTS_PURCHASED INT,
	CUS_TOTAL_QUANTITY_OF_ORDER INT,
	CUS_DATE_OF_LAST_PURCHASE DATE,
);
GO

CREATE TABLE PRODUCTTYPE(
	PRD_TYPE_ID NVARCHAR(50) PRIMARY KEY,
	PRD_TYPE_NAME NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE PRODUCT (
	PRD_IMG VARCHAR(1000), 
    PRD_ID VARCHAR(100) PRIMARY KEY,
    PRD_NAME NVARCHAR(255) NOT NULL,
    PRD_TYPE_ID NVARCHAR(50) NOT NULL,
    BRD_ID VARCHAR(100) NOT NULL,
    RDY_FOR_SALE INT NOT NULL,
    QUANTITY INT NOT NULL,
	DELIVERY_ALLOWED BIT NOT NULL,
	PRD_WEIGHT FLOAT,
	CREATE_DAY DATE,
	CONSTRAINT FK_PRODUCT_BRAND FOREIGN KEY (PRD_ID) REFERENCES BRAND(BRD_ID),
	CONSTRAINT FK_PRODUCT_PRODUCTTYPE FOREIGN KEY (PRD_TYPE_ID) REFERENCES PRODUCTTYPE(PRD_TYPE_ID)
);
GO


ALTER TABLE product
drop constraint FK_PRODUCT_BRAND
ALTER COLUMN BRD_ID VARCHAR(100) NOT NULL;
CREATE TABLE WAREHOUSE(
	PRD_IMG VARCHAR(1000),
	PRD_ID VARCHAR(100) PRIMARY KEY,
	PRD_NAME NVARCHAR(100) NOT NULL,
	PRD_TYPE_ID NVARCHAR(50) NOT NULL,
	BRD_ID VARCHAR(100) NOT NULL,
	RDY_FOR_SALE INT NOT NULL,
	INVENTORY_QUANTITY INT NOT NULL, 
	CREATE_DAY DATE,
	RETAIL_PRICE FLOAT NOT NULL,
	IMPORT_PRICE FLOAT NOT NULL,
	WHOLESALE_PRICE FLOAT NOT NULL
	CONSTRAINT FK_WAREHOUSE_BRAND FOREIGN KEY (BRD_ID) REFERENCES BRAND(BRD_ID),
	CONSTRAINT FK_WAREHOUSE_PRODUCTTYPE FOREIGN KEY (PRD_TYPE_ID) REFERENCES PRODUCTTYPE(PRD_TYPE_ID)
)
GO

CREATE TABLE PAYMENT (
	PMT_NAME NVARCHAR(50) PRIMARY KEY
);
GO

CREATE TABLE DISCOUNT(
	CODE VARCHAR(100) PRIMARY KEY,
	DISCOUNT_PERCENT FLOAT,
	MAXIMUM_USE INT,
	USED_COUNT INT,
	MAXIMUM_DISCOUNT_AMOUNT FLOAT
); 
GO

CREATE TABLE SALEBILL (
    SL_ID VARCHAR(100) PRIMARY KEY,
    SL_DATE DATE NOT NULL,
    CUS_ID VARCHAR(100) NOT NULL,
    EMP_ID VARCHAR(100) NOT NULL, 
	DISCOUNT_CODE VARCHAR(100),
    TOTAL_MONEY FLOAT,
    PAYMENT NVARCHAR(50) NOT NULL,
    NOTE NVARCHAR(255),
	MONEY_CUSTOMER_GIVE FLOAT,
	REFUND FLOAT,
	STATUS NVARCHAR(255),
    CONSTRAINT FK_SALEBILL_CUSTOMER FOREIGN KEY (CUS_ID) REFERENCES CUSTOMER(CUS_ID),
    CONSTRAINT FK_SALEBILL_EMPLOYEES FOREIGN KEY (EMP_ID) REFERENCES EMPLOYEES(EMP_ID),
	CONSTRAINT FK_SALEBILL_DISCOUNT FOREIGN KEY (DISCOUNT_CODE) REFERENCES DISCOUNT(CODE),
	CONSTRAINT FK_SALEBILL_PAYMENT FOREIGN KEY (PAYMENT) REFERENCES PAYMENT(PMT_NAME)
);
GO

CREATE TABLE SALEBILL_DETAIL (
	SL_DETAIL_ID VARCHAR(100) PRIMARY KEY,
    SL_ID VARCHAR(100) NOT NULL,
    PRD_ID VARCHAR(100) NOT NULL,
    QUANTITY INT NOT NULL,
    PRICE FLOAT,
    CONSTRAINT FK_SALEBILL_DETAIL_SALEBILL FOREIGN KEY (SL_ID) REFERENCES SALEBILL(SL_ID),
    CONSTRAINT FK_SALEBILL_DETAIL_PRODUCT FOREIGN KEY (PRD_ID) REFERENCES PRODUCT(PRD_ID)
);
GO

CREATE TABLE IMPORTBILL(
	IB_ID VARCHAR(100) PRIMARY KEY,
	BRD_ID VARCHAR(100) NOT NULL,
	EMP_ID VARCHAR(100) NOT NULL,
	IB_DATE DATETIME NOT NULL,
	TOTAL_MONEY FLOAT,
	NOTE NVARCHAR(255),
	CONSTRAINT FK_IMPORTBILL_BRAND FOREIGN KEY (BRD_ID) REFERENCES BRAND(BRD_ID),
    CONSTRAINT FK_IMPORTBILL_EMPLOYEES FOREIGN KEY (EMP_ID) REFERENCES EMPLOYEES(EMP_ID) 
);
GO

CREATE TABLE IMPORTBILL_DETAIL(
	IB_DETAIL_ID VARCHAR(100) PRIMARY KEY,
	IB_ID VARCHAR(100) NOT NULL,
	PRD_ID VARCHAR(100) NOT NULL,
	QUANTITY INT,
	IB_PRICE FLOAT,
	CONSTRAINT FK_IMPORTBILL_DETAIL_IMPORTBILL FOREIGN KEY (IB_ID) REFERENCES IMPORTBILL(IB_ID),
    CONSTRAINT FK_IMPORTBILL_DETAIL_WAREHOUSE FOREIGN KEY (PRD_ID) REFERENCES WAREHOUSE(PRD_ID) 
);
GO







alter PROC PROC_LOGIN
@username VARCHAR(255),
@password VARCHAR(255)
AS
BEGIN
	SELECT * FROM EMPLOYEES WHERE EMP_ACCOUNT = @username AND EMP_PASSWORD = @password
END

exec PROC_LOGIN 'admin', 'admin'


select * from brand
drop proc PROC_LOGIN

--Insert data
INSERT INTO BRAND (BRD_ID, BRD_NAME, BRD_ADDRESS, BRD_PHONE, BRD_EMAIL, BRD_STATUS) VALUES
('NCC1', 'Apple Inc.', '1 Apple Park Way, Cupertino, CA 95014, USA', '14089961010', 'contact@apple.com', N'Đang hợp tác'),
('NCC2', 'Dell Technologies', 'One Dell Way, Round Rock, TX 78682, USA', '18004544081', 'support@dell.com', N'Đang hợp tác'),
('NCC3', 'HP Inc.', '1501 Page Mill Road, Palo Alto, CA 94304, USA', '18004746836', 'info@hp.com', N'Đang hợp tác'),
('NCC4', 'Lenovo Group Ltd.', 'No.6 Chuang Ye Road, Shangdi Information Industry Base, Haidian District, Beijing, China', '861062043888', 'support@lenovo.com', N'Đang hợp tác'),
('NCC5', 'Acer Inc.', '8F, No.88, Sec. 1, Xintai 5th Road, Xizhi, New Taipei City 221, Taiwan', '886226996123', 'info@acer.com', N'Đang hợp tác'),
('NCC6', 'ASUS', '15 Li-Te Road, Beitou District, Taipei 112, Taiwan', '886289569588', 'contact@asus.com', N'Đang hợp tác'),
('NCC7', 'Microsoft', 'One Microsoft Way, Redmond, WA 98052, USA', '18006427676', 'support@microsoft.com', N'Đang hợp tác'),
('NCC8', 'Samsung Electronics', '129 Samsung-ro, Yeongtong-gu, Suwon-si, Gyeonggi-do, 16677, South Korea', '821234567890', 'support@samsung.com', N'Đang hợp tác'),
('NCC9', 'Intel Corporation', '2200 Mission College Blvd., Santa Clara, CA 95054-1549, USA', '14087653500', 'support@intel.com', N'Đang hợp tác'),
('NCC10', 'Razer Inc.', '201 3rd Street, Suite 900, San Francisco, CA 94103, USA', '18555887293', 'support@razer.com', N'Đang hợp tác'),
('NCC11', 'Logitech', 'Logitech International S.A., EPFL - Quartier de l''Innovation, Daniel Borel Innovation Center, 1015 Lausanne, Switzerland', '41216179200', 'support@logitech.com', N'Đang hợp tác'),
('NCC12', 'Corsair', '47100 Bayside Parkway, Fremont, CA 94538, USA', '18882224302', 'support@corsair.com', N'Đang hợp tác'),
('NCC13', 'MSI', 'No.69, Lide St., Zhonghe Dist., New Taipei City 235, Taiwan', '886289963388', 'info@msi.com', N'Đang hợp tác'),
('NCC14', 'Gigabyte Technology', 'No.6, Baoqiang Rd., Xindian Dist., New Taipei City 231, Taiwan', '886282187650', 'support@gigabyte.com', N'Đang hợp tác'),
('NCC015', 'Alienware', '14591 SW 120th Street, Miami, FL 33186, USA', '18004544081', 'alienware@dell.com', N'Đang hợp tác');
GO

--Product type
INSERT INTO PRODUCTTYPE (PRD_TYPE_ID, PRD_TYPE_NAME) VALUES
('PT1', N'Máy tính xách tay'),
('PT2', N'Máy tính để bàn'),
('PT3', N'Màn hình máy tính'),
('PT4', N'Bàn phím'),
('PT5', N'Chuột máy tính'),
('PT6', N'Loa máy tính'),
('PT7', N'Tai nghe'),
('PT8', N'Ổ cứng di động'),
('PT9', N'USB'),
('PT10', N'Máy in');

INSERT INTO WAREHOUSE (PRD_ID, PRD_NAME, PRD_TYPE_ID, BRD_ID, RDY_FOR_SALE, INVENTORY_QUANTITY, CREATE_DAY, RETAIL_PRICE, IMPORT_PRICE, WHOLESALE_PRICE)
VALUES
('PRD1', N'Macbook Pro', 'PT001', 'NCC001', 1, 100, GETDATE(), 46000000, 34500000, 41400000),
('PRD2', N'Dell XPS 15', 'PT001', 'NCC002', 1, 120, GETDATE(), 41400000, 32200000, 36800000),
('PRD3', N'HP Spectre x360', 'PT001', 'NCC003', 1, 90, GETDATE(), 39100000, 29900000, 34500000),
('PRD4', N'Lenovo ThinkPad X1 Carbon', 'PT001', 'NCC004', 1, 80, GETDATE(), 36800000, 27600000, 32200000),
('PRD5', N'Acer Swift 5', 'PT001', 'NCC005', 1, 110, GETDATE(), 32200000, 24150000, 27600000),
('PRD6', N'ASUS ZenBook', 'PT001', 'NCC006', 1, 95, GETDATE(), 34500000, 27600000, 32200000),
('PRD7', N'Surface Laptop', 'PT001', 'NCC007', 1, 85, GETDATE(), 41400000, 32200000, 36800000),
('PRD8', N'Samsung Galaxy Book Flex', 'PT001', 'NCC008', 1, 100, GETDATE(), 34500000, 25300000, 29900000),
('PRD9', N'Intel NUC', 'PT002', 'NCC009', 1, 75, GETDATE(), 20700000, 15500000, 17250000),
('PRD10', N'Razer Blade 15', 'PT001', 'NCC010', 1, 70, GETDATE(), 46000000, 36800000, 41400000),
('PRD11', N'Logitech MX Master 3', 'PT005', 'NCC011', 1, 150, GETDATE(), 2580000, 1795000, 2070000),
('PRD12', N'Corsair K95 RGB Platinum', 'PT004', 'NCC012', 1, 130, GETDATE(), 4600000, 3450000, 4140000),
('PRD13', N'MSI Optix MAG271CQR', 'PT003', 'NCC013', 1, 90, GETDATE(), 20700000, 15500000, 17250000),
('PRD14', N'Gigabyte AORUS AD27QD', 'PT003', 'NCC014', 1, 80, GETDATE(), 25800000, 17950000, 20700000),
('PRD15', N'Alienware AW3418DW', 'PT003', 'NCC015', 1, 70, GETDATE(), 55200000, 41400000, 46000000);


select B.brd_id from brand b
inner join product p on p.BRD_ID = b.BRD_ID
where p.PRD_ID = 'PRD007'
select brd_id from PRODUCT

delete from WAREHOUSE

INSERT INTO POSITION (PS_ID, PS_NAME, PS_NOTE)
VALUES
    ('PS001', N'Quản lý', N'Vai trò quản lý chung'),
    ('PS002', N'Nhân viên bán hàng', N'Nhân viên phục vụ khách hàng');

INSERT INTO AUTHORITY (AUT_ID, AUT_NAME)
VALUES
    ('AUT001', N'Insert'),
    ('AUT002', N'Update'),
    ('AUT003', N'Delete');

INSERT INTO POSITION_AUTHORITY (ID, PS_ID, AUT_ID, ROLE_TYPE)
VALUES
    ('PA001', 'PS001', 'AUT001', N'Đọc và ghi'),
    ('PA002', 'PS001', 'AUT002', N'Chỉ đọc'),
    ('PA003', 'PS002', 'AUT001', N'Đọc và ghi'),
    ('PA004', 'PS002', 'AUT002', N'Chỉ đọc'),
    ('PA005', 'PS002', 'AUT003', N'Không có quyền');

INSERT INTO EMPLOYEES (EMP_ID, EMP_NAME, EMP_PHONE_NUMBER, EMP_BIRTHDAY, EMP_GENDER, EMP_PROVINCE, EMP_DISTRICT, EMP_WARD, EMP_ADDRESS, EMP_EMAIL, EMP_ACCOUNT, EMP_PASSWORD, HIRE_DATE, PS_ID, EMP_STATUS)
VALUES
    ('EMP001', N'Nguyễn Văn A', '0123456789', '1990-01-01', N'Nam', N'Hà Nội', N'Cầu Giấy', N'Dịch Vọng', N'Số 1, Đường ABC', 'example1@example.com', 'employee1', 'password1', GETDATE(), 'PS001', N'Đã nghỉ việc'),
    ('EMP002', N'Nguyễn Thị B', '0987654321', '1995-05-05', N'Nữ', N'Hồ Chí Minh', N'Quận 1', N'Bến Nghé', N'Số 2, Đường XYZ', 'example2@example.com', 'employee2', 'password2', GETDATE(), 'PS002', N'Đang làm việc');



-- Chèn dữ liệu vào bảng IMPORTBILL
INSERT INTO IMPORTBILL (IB_ID, BRD_ID, EMP_ID, IB_DATE, TOTAL_MONEY, NOTE)
VALUES
    ('IB001', 'NCC001', 'EMP001', GETDATE(), 0, N'Giao dịch nhập hàng số 001'),
    ('IB002', 'NCC002', 'EMP002', GETDATE(), 0, N'Giao dịch nhập hàng số 002');

-- Chèn dữ liệu vào bảng IMPORTBILL_DETAIL
INSERT INTO IMPORTBILL_DETAIL (IB_DETAIL_ID, IB_ID, PRD_ID, QUANTITY, IB_PRICE)
VALUES
    ('IBD001', 'IB001', 'PRD001', 5, 34500000),
    ('IBD002', 'IB001', 'PRD002', 10, 32200000),
    ('IBD003', 'IB002', 'PRD003', 8, 29900000),
    ('IBD004', 'IB002', 'PRD004', 6, 27600000);








--Trigger
--tự động cập nhật dữ liệu bảng product khi cập nhật warehouse
drop trigger trg_InsertWarehouse
drop trigger trg_DeleteWarehouse
drop trigger trg_UpdateWarehouse

CREATE TRIGGER trg_InsertWarehouse
ON WAREHOUSE 
AFTER INSERT
AS
BEGIN
    INSERT INTO PRODUCT (PRD_IMG, PRD_ID, PRD_NAME, PRD_TYPE_ID, BRD_ID, RDY_FOR_SALE, QUANTITY, DELIVERY_ALLOWED, PRD_WEIGHT)
    SELECT i.PRD_IMG, i.PRD_ID, i.PRD_NAME, i.PRD_TYPE_ID, i.BRD_ID, i.RDY_FOR_SALE, i.INVENTORY_QUANTITY, 1, 0
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1
        FROM PRODUCT p
        WHERE p.PRD_ID = i.PRD_ID
    );
END;

CREATE TRIGGER trg_UpdateWarehouse
ON WAREHOUSE
AFTER UPDATE
AS
BEGIN
    UPDATE p
    SET p.PRD_NAME = i.PRD_NAME,
        p.PRD_TYPE_ID = i.PRD_TYPE_ID,
        p.BRD_ID = i.BRD_ID,
        p.RDY_FOR_SALE = i.RDY_FOR_SALE,
        p.QUANTITY = i.INVENTORY_QUANTITY
    FROM PRODUCT p
    INNER JOIN inserted i ON p.PRD_ID = i.PRD_ID;
END;

CREATE TRIGGER trg_DeleteWarehouse
ON WAREHOUSE
AFTER DELETE
AS
BEGIN
    DELETE FROM PRODUCT
    WHERE PRD_ID IN (
        SELECT d.PRD_ID
        FROM deleted d
    );
END;

--Trigger tự động cập nhật dữ liệu bảng warehouse khi bảng product thay đổi: 
CREATE TRIGGER trgProductInsert
ON PRODUCT
AFTER INSERT
AS
BEGIN
    INSERT INTO WAREHOUSE (PRD_IMG, PRD_ID, PRD_NAME, PRD_TYPE_ID, BRD_ID, RDY_FOR_SALE, INVENTORY_QUANTITY, CREATE_DAY, RETAIL_PRICE, IMPORT_PRICE, WHOLESALE_PRICE)
    SELECT 
        i.PRD_IMG, 
        i.PRD_ID, 
        i.PRD_NAME, 
        i.PRD_TYPE_ID, 
        i.BRD_ID, 
        i.RDY_FOR_SALE, 
        i.QUANTITY AS INVENTORY_QUANTITY, 
        i.CREATE_DAY, 
        0 AS RETAIL_PRICE,  -- Giá bán lẻ mặc định là 0, cần điều chỉnh nếu có logic giá cụ thể
        0 AS IMPORT_PRICE,  -- Giá nhập mặc định là 0, cần điều chỉnh nếu có logic giá cụ thể
        0 AS WHOLESALE_PRICE  -- Giá bán buôn mặc định là 0, cần điều chỉnh nếu có logic giá cụ thể
    FROM INSERTED i;
END;

CREATE TRIGGER trgProductUpdate
ON PRODUCT
AFTER UPDATE
AS
BEGIN
    UPDATE w
    SET 
        w.PRD_IMG = i.PRD_IMG, 
        w.PRD_NAME = i.PRD_NAME, 
        w.PRD_TYPE_ID = i.PRD_TYPE_ID, 
        w.BRD_ID = i.BRD_ID, 
        w.RDY_FOR_SALE = i.RDY_FOR_SALE, 
        w.INVENTORY_QUANTITY = i.QUANTITY, 
        w.CREATE_DAY = i.CREATE_DAY
    FROM WAREHOUSE w
    INNER JOIN INSERTED i ON w.PRD_ID = i.PRD_ID
    INNER JOIN DELETED d ON w.PRD_ID = d.PRD_ID;
END;

CREATE TRIGGER trgProductDelete
ON PRODUCT
AFTER DELETE
AS
BEGIN
    DELETE FROM WAREHOUSE
    WHERE PRD_ID IN (SELECT PRD_ID FROM DELETED);
END;


CREATE OR ALTER TRIGGER trg_update_importbill_total
ON IMPORTBILL_DETAIL
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    IF (EXISTS (SELECT 1 FROM inserted) OR EXISTS (SELECT 1 FROM deleted))
    BEGIN
        UPDATE IMPORTBILL
        SET TOTAL_MONEY = (
            SELECT SUM(ibd.QUANTITY * ibd.IB_PRICE)
            FROM IMPORTBILL_DETAIL ibd
            WHERE ibd.IB_ID = IMPORTBILL.IB_ID
        )
        FROM IMPORTBILL
        WHERE IMPORTBILL.IB_ID IN (
            SELECT IB_ID FROM inserted
            UNION
            SELECT IB_ID FROM deleted
        );
    END
END;


--Function
--Tìm kiếm sảm phẩm
ALTER FUNCTION TimKiemSanPham
(
    @BRD_ID VARCHAR(100) = NULL,
    @PRD_TYPE_ID NVARCHAR(50) = NULL,
    @KEYWORD  NVARCHAR(255) = NULL
)
RETURNS TABLE
AS
RETURN
(
    SELECT * 
    FROM PRODUCT
    WHERE 
        (@BRD_ID IS NULL OR BRD_ID = @BRD_ID)
        AND (@PRD_TYPE_ID IS NULL OR PRD_TYPE_ID = @PRD_TYPE_ID)
        AND (@KEYWORD IS NULL OR PRD_NAME LIKE '%' + @KEYWORD + '%' COLLATE Vietnamese_CI_AS OR PRD_ID = @KEYWORD)
)

SELECT * FROM TimKiemSanPham('NCC014', null, null);
SELECT * FROM TimKiemSanPham(NULL, 'PT003', null);
SELECT * FROM TimKiemSanPham(NULL, null, 'PRD003');

SELECT * FROM PRODUCTTYPE
drop function TimKiemSanPham