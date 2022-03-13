function tablePlugin(selector, url, columns,lang) {

    var tab = $(selector).DataTable({
        lengthChange: true,
        info: true,
        searching: true,
        search: true,
        ordering: true,
        responsive: true,
        searchable: true,
        processing: true,
        serverSide: true,
        language: {

            sProcessing: lang.sProcessing,
            sLengthMenu: lang.sLengthMenu,
            sZeroRecords: lang.sZeroRecords,
            sInfo: lang.sInfo,
            sInfoEmpty: lang.sInfoEmpty,
            sInfoFiltered: lang.sInfoFiltered,
            sInfoPostFix: "",
            sSearch: lang.sSearch,
            sUrl: "",
            oPaginate: {
                sFirst: lang.sFirst,
                sPrevious: lang.sPrevious,
                sNext: lang.sNext,
                sLast: lang.sLast
            }

        },
        ajax: {
            url: url,
            async: true,
            dataSrc: function (json) {

                console.log(json);
                return json.data;
            }
        },
        columns: columns

    });
    return tab;
}