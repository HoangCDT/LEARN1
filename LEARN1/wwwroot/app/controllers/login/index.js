
var LoginController = {
    Init() {
        this.Register();
    },
    Register() {
        let self = this;
        $('#btnLogin').on('click', function (e) {
            e.preventDefault();
            var user = $('#txtUserName').val();
            var pass = $('#txtPassword').val();
            self.Methods.login(user, pass);
        });
    },
    Methods: {
        login(user, pass) {
            $.ajax({
                type: 'POST',
                data: {
                    UserName : user,
                    Password: pass
                },
                dataType: 'json',
                url: 'admin/login/authen',
                success: function (res) {
                    if (res.Success) {
                        window.location.href = "/Admin/AdminHome/Index";
                    } else {
                        qlvs.notify('User hoặc pass chưa đúng!', 'error');
                    }
                }
            })
        }
        
    }
}

LoginController.Init();