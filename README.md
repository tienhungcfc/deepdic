# DeepDoc
*Chuyển đổi cấu trúc dạng bảng sang cấu trúc json, kèm them các tiện ích*



Trước tiên ta có các bảng mẫu

- **Categories**

ID | Title | Desc
------------ | ------------- | -------------
1001 | Danh mục 1 | Mô tả danh mục 1
1002 | Danh mục 2 | Mô tả danh mục 2

- **Aricles**

ID | Title | Desc | Content
------------ | ------------- | ------------- | ---------
2001 | Bài viết 1 | Mô tả Bài viết 1 | Nội dung 1
2002 | Bài viết 2 | Mô tả Bài viết 2 | Nội dung 2


## Ngữ pháp
*Mỗi câu lệnh bắt đầu từ đầu dòng, có thể bao gồm 1 hoặc nhiều dòng*

Bắt đầu
#### alias - Bí danh
> alias **TableName** *aliasName*
``` 
alias Categories cate
alias Aricles art
```

#### var - Khai báo
> var **Tên biến**: *kiểu giá trị*
```
var x1 = {}//Kiểu json, có thể mở rộng thuộc tính bất kỳ
var x2 = []//Kiểu mảng, 
var x3 = 0
var x4 = true
var x5 = now()//Kiểu datetime
var x6 = ''//String
```
