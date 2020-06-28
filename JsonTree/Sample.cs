class Root
    {
        /// <summary>
        /// output: A= { members= [{member1}, {member2},...]}
        /// </summary>
        [JsonTree.SelectSQL]
        [JsonTree.SelectSQL(
            Cmd = "select * from [members] where [BirthDate]>= '1987-01-01' order by FullName"
            )]
        public class members
        {
            /// <summary>
            /// output: danh sách đơn hàng cửa từng member
            /// Select: được format runtime sử dụng cấu trúc {{...}}
            /// Cú pháp: {{}} sử dụng hàm và truyền biến, các hàm trả ra giá trị(string,int,double)
            /// Methods: orwhere,getids,getRoot là các hàm có sẵn, có thể tùy biến cộng thêm sử dụng 
            /// Note: Chỉ sử dụng ký tự " để truyền biến kiểu string trong {{...}}
            /// </summary>
            [JsonTree.SelectSQL]
            [JsonTree.SelectSQL(
                Cmd = "select * from [orders] where {{whereOr('[senderID]={0}', getprops(Root, 'Root.members', 'ID'))}}",
                Select = JsonTree.SelectTypes.once,
                OnEach = "$.SenderID = this.ID"
                )]
            public class orders
            {

                class payed
                {
                    [JsonTree.SelectSQL]

                    class cashs
                    {

                    }
                }

                class _return
                {

                }

            }
        }

        //public int A = 0;
        //int B { get; set; }

        class c
        {

        }
    }
