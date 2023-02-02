

$.ajax({

    async: true,
    crossDomain: true,
    method: "GET",
    contentType: "application/json; charset=utf-8",
    url: "/jsons/web-series.json/english-series.json",
    /*headers: {
        "x-rapidapi-host": "coronavirus-monitor.p.rapidapi.com",
        "x-rapidapi-key": "88e8626ed3msha214459b297f3adp19ea59jsnc0458ee19fea"
    },*/
    dataType: "json",
    success: function (response) {
        console.log(response);
       
        for (i in response) {

            $("#results").append(`<div class="item">
       <a href="/htmls/tvshowreview.html?${$.param(response[i])}">
       <video src="${response[i].trailer}" class="rounded img-thumbnail vt video" id="vt" poster="${response[i].poster}">
        
       </video>
   </a>
   </div>`);

            // console.log(${response[i].trailer);

            //for (j in response.countries_stat[i].country_name[i]) {
            //  console.log( response.countries_stat[i].country_name);
            //}
        }

        $(document).ready(function () {




            $(".center").slick({

                slidesToShow: 4,
                slidesToScroll: 4,
                mobileFirst: true,

                responsive: [{

                    breakpoint: 1024,
                    settings: {
                        swipe: false,
                        slidesToShow: 4,

                    }

                }, {

                    breakpoint: 600,
                    settings: {
                        slidesToShow: 4,

                    }

                },

                ]


            });





            function createSlick() {
                $(".center").not('.slick-initialized').slick({
                    autoplay: true,
                    arrows: true,
                    slidesToShow: 4,
                    slidesToScroll: 1,
                    responsive: [
                        {
                            breakpoint: 1024,
                            settings: "unslick"
                        },
                        {
                            breakpoint: 600,
                            settings: "unslick"
                        },
                        {
                            breakpoint: 481,
                            settings: {
                                slidesToShow: 1,
                                slidesToScroll: 1
                            }
                        }
                    ]
                });
            }
            createSlick();

            $(window).on('resize', createSlick);







            var videos = document.querySelectorAll(".vt");

            videos.forEach(video => {

                video.addEventListener("mouseover", function () {
                    this.play()

                    //alert()
                })

                video.addEventListener("mouseout", function () {

                    this.pause();
                    //this.poster="/htmls/images/slide2.jpg"
                    this.load();
                })


            })


            videos.forEach(function (vid, idx) {
                vid.addEventListener('ended', resetVideo, false);
            });

            function resetVideo(e) {
                this.load();
            }

        });

    },
    error: function (result) {
        alert("Error");
    }
});



