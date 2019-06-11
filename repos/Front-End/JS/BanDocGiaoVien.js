$(function () {
// hiện popup cho phần menu của table
    $(".registry-popup").dialog({
        autoOpen: false,
        resizable: false,
        height: "auto",
        width: 400,
        modal: true,
        title: "Đăng kí bạn đọc",
        buttons: {
            "Cất": function () {
                $(this).dialog("close");
            },
            "Hủy bỏ": function () {
                $(this).dialog("close");
            }
        }
    });
    $(".registry span, .separation ").on("click", function () {
        $(".registry-popup").dialog("open");
    });

    $(".edit-popup").dialog({
        autoOpen: false,
        resizable: false,
        height: "auto",
        width: 400,
        modal: true,
        title: "Đăng kí bạn đọc",
        buttons: {
            "Cất": function () {
                $(this).dialog("close");
            },
            "Hủy bỏ": function () {
                $(this).dialog("close");
            }
        }
    });
    $(".edit").on("click", function () {
        $(".edit-popup").dialog("open");
    });

    $(".delete-popup").dialog({
        autoOpen: false,
        resizable: false,
        height: "auto",
        width: 400,
        modal: true,
        title: "Đăng kí bạn đọc",
        buttons: {
            "Cất": function () {
                $(this).dialog("close");
            },
            "Hủy bỏ": function () {
                $(this).dialog("close");
            }
        }
    });
    $(".delete").on("click", function () {
        $(".delete-popup").dialog("open");
    });
    $(".import-popup").dialog({
        autoOpen: false,
        resizable: false,
        height: "auto",
        width: 400,
        modal: true,
        title: "Đăng kí bạn đọc",
        buttons: {
            "Cất": function () {
                $(this).dialog("close");
            },
            "Hủy bỏ": function () {
                $(this).dialog("close");
            }
        }
    });
    $(".import").on("click", function () {
        $(".import-popup").dialog("open");
    });
    $(".import-many-popup").dialog({
        autoOpen: false,
        resizable: false,
        height: "auto",
        width: 400,
        modal: true,
        title: "Đăng kí bạn đọc",
        buttons: {
            "Cất": function () {
                $(this).dialog("close");
            },
            "Hủy bỏ": function () {
                $(this).dialog("close");
            }
        }
    });
    $(".import-many").on("click", function () {
        $(".import-many-popup").dialog("open");
    });
    $(".print-card-popup").dialog({
        autoOpen: false,
        resizable: false,
        height: "auto",
        width: 400,
        modal: true,
        title: "Đăng kí bạn đọc",
        buttons: {
            "Cất": function () {
                $(this).dialog("close");
            },
            "Hủy bỏ": function () {
                $(this).dialog("close");
            }
        }
    });
    $(".print-card").on("click", function () {
        $(".print-card-popup").dialog("open");
    });
// show/hide dropdown phần menu của table và phần dropdown header
    $(".dropdown-btn").on("click", function() {
        $(this).next().toggle("show");
    });       
    $("#registry-dropdown").on("click", function () {
        $(this).parent().next().toggle("show");
    });

    window.onclick = function (event) {
        if (!event.target.matches('dropdown-btn')) {
            var dropdowns = document.getElementsByClassName("dropdown-content-top");
            var i;
            for (i = 0; i < dropdowns.length; i++) {
                var openDropdown = dropdowns[i];
                if (openDropdown.classList.contains('show')) {
                    openDropdown.classList.remove('show');
                }
            }
        }
    };
});

