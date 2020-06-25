
var LoginController = {
    Init() {
        this.Register();
    },
    Register() {
        let self = this;
        $('#btnLogin').on('click', function (e) {
            e.preventDefault();
            self.Methods.validationLogin();
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
                url: '/Admin/Login/Authen',
                success: function (res) {
                    if (res.Success) {
                        window.location.href = "/Admin/AdminHome/Index";
                    } else {
                        qlvs.notify('User hoặc pass chưa đúng!', 'error');
                        $('#txtUserName').val
                    }
                }
            })
        },
        validationLogin() {
            let self = this;
            var valiObj = $('#login-form').validate({
                rules: {
                    name: "required",
                    password: "required"
                },
                messages: {
                    name: "Chưa nhập tài khoản",
                    password: "Chưa nhập mật khẩu"
                },
                submitHandler: function () {
                    var user = $('#txtUserName').val();
                    var pass = $('#txtPassword').val();
                    self.login(user, pass);
                }
            });
        }
        
    }
}

LoginController.Init();