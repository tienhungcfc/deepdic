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
Let'go

#### Khai báo mới trong c#:
```
var dd = new DeepDoc()
dd["x0"] = null; //any, bool, string, int, null... 
dd["fnName"]= (int a, int b) => { return a + b;}
dd.Inner = @"
    data = {}
    x = "chuỗi 1"
    data.a = x // output {"a":"chuỗi 1"}
";

```

#### Bắt đầu
```
dd.Append = @"
//Mỗi câu lệnh sẽ bắt đầu bằng dòng mới, có thể gồm 1 hay nhiều dòng
    data.a  = 1 // chuyển thành kiểu số
    data.a += 1 // output: {"a":2}
    data.a = 'Tôi là tôi'// output: {"a":"Tôi là tôi"}
    a = 0
    x = 0 //output: 0
    x.z = 0 //output: {"z":0}
";

var data = dd["data"]; //data kiểu dictionary
var a = dd["a"]; //output: 0,  a kiểu int
var z = dd["x"]; 
//or
var z = dd["x"]["z]"; //phải  
```

#### Với bảng
```
dd.Append = @"
   alias Categories cate //Gán bí danh cho bảng sử dụng mẫu câu: alias [TEN_BANG] ten
   alias Articles arts
   x = {}
   x.categories = cate      // danh sách categories, dữ liệu đc đọc từ sql, chuyển ngay bào bộ nhớ của c#, một dạng cache
   x.first = cate[0]        // x giờ là phần từ đầu tiên của categories hoặc null
   x.last = cate[.]         // x giờ là phần từ cuối của categories hoặc null
   
   x.filter = from c in  cate 
              where c.ID >= 0                   //xem dánh sách toán tử cho câu lệnh from ... where 
                    and c.Parent == 0
              order by c.Order, c.ID desc       // cú pháp như sql, bản chất lst.Order[Desc]By().thenBy(..)
              
   x.filter[0].arts = arts //mở rộng 1 thuộc tích cho thành phần đầu tiên của filter
   
   x.cates = sql c cate                             // đọc trực tiếp từ db
             where c.ID >= 0                        // tương tự như câu lệnh "from", chú ý
                   or c.ID not null
                   or c.ID not in arts.Channel      // trình biên dịch sẽ soạn thành: c.ID not in (select Channel from  articles)
                   or c.ID not in arr(arts.Chanel)  // arr() là hàm dựng sẵn,sẽ soạn thành: (c.ID != Id1 or c.ID != Id2 ...) 
             order by c.ID
";
```
#### Toán tử
- Các phép tính cơ bản: Cộng(+), trừ(-), nhân(\*), chia(/), mũ(^)
- Các phép tính logic: Và(and), Hoặc(or), Bằng(==), Khác(!=), Lớn hơn(>), Nhỏ hơn(>),Lớn hơn bằng(>=), Nhỏ hơn bằng(<=)

#### Các hàm dựng sẵn
- close: tạo bản sao
```
    x = {a:1}
    y = clone(x)
    x.a = 2 // output: x = {"a":2}, y = {"a":1}
```
- delete: xóa 
```
    x = {a:1, b:2}
    delete x.a // output: x = {"b":2}
```
- arr: tạo mảng giá trị từ thuộc tính
```
    x = arr[arts.Channel] //output: x = ["1","1,2",...]
    ... from c in cate
            where c.ID in  arr[arts.Channel] // sẽ soạn thành: ["1","1,2",...].any(x => x == c.ID) trong c#
    ... sql c in cate
            where c.ID in  arr[arts.Channel] // sẽ soạn thành: (",1," like '%,'+ cast(c.ID as nvarchar) +',%' or ... ) trong sql
```

#### Chạy
```
dd.Run();
```

#### Truy vấn kết quả
```


```





