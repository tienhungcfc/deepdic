#bí danh
alias table(articles) art
alias table(Category) cate
alias table(Adv) adv

#Khái niệm biến: 
# - Kiểu đơn 
var x:{} = 0
var y:{}
var z


# - Kiểu danh sách
var dic:[] = art

#Xây dựng thuộc tính mowr rộng
# - Thuộc tính object
for dic.Category = cate where dic.Chnnels ~ cate.ID

# - Thuộc tính giá trị
for dic.CategoryTitle = cate.Title where dic.Chnnels ~ cate.ID

# - Thuộc tính mảng
for dic.Categorys = [cate]

# - Tiếp tục mở rộng thuộc tính của thuộc tính
for dic.Category.AdvTitle = adv.Title where adv.ID = dic.Category.AdvID

#Toán tử
# - Cơ bản
# -- Phép nhân "*"
# -- Phép chia "/"
# -- Phép trừ "-"
# -- Phép cộng "+"

# - Login:
# -- Bao gồm "~"
# -- Giống nhau(bằng nhau) "="
