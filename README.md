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
Trong c#:

Bắt đầu
#### alias - Bí danh
> alias **TableName** *aliasName*
``` 
alias Categories cate
alias Aricles art
```

#### var - Khai báo
> var **Tên biến**: *Giá trị*
- Tên biến: az_09, bắt đầu bằng chữ cái.
- Có thể gán tùy ý các giá trị với các kiểu khác nhau cho biến cho biến, ví dụ: var x = 0. sau đó x = true.
```
var x1 = {}//Kiểu json, có thể mở rộng thuộc tính bất kỳ
var x2 = []//Kiểu mảng, 
var x3 = 0// Kiểu số
var x4 = true//Kiểu bool
var x5 = date()//Kiểu datetime
var x6 = ''//String

// String nhiều dòng
var x7 = `
line 1
line 2
`

```
