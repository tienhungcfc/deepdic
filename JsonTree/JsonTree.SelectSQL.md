
# Thuộc tính đánh dấu khai báo truy vấn
``` c#
class Root
    {
        [JsonTree.SelectSQL(
            Cmd = "select * from [members] where [BirthDate]>= '1987-01-01' order by FullName"
            )]
        public class members
        {...
```
## Các thuộc tính
Cmd,IsSigle,Select,OnEach
### Cmd
- ***string***: câu lệnh truy vấn sql
### IsSigle
- ***bool***: đặt là ***true*** nếu muốn trả về kiểu đơn lẻ
### Select
- 
### OnEach
- ***string***: 
