var loginController = function () {

    this.initialize = function () {
        registerEvent();
    }

    var registerEvent = function () {
        $('#btnLogin').on('Click', function (e) {
            e.preventDefault();
            var user = $('txtUserName').val();
            var pass = $('txtPassWord').val();
            login(user, pass);
        });
    }

    var login = function (user, pass) {
        $.ajax({
            type: 'POST',
            data: {
                UserName = user,
                Password = pass
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