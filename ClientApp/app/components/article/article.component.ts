import { Component, OnInit, Inject } from '@angular/core';
import { ArticleService } from '../services/article.service';
import { ArticelModel } from '../models/article.model';
import { Http } from '@angular/http'
@Component({
    selector: 'article',
    templateUrl: './article.component.html'
})
export class ArticleComponent {

    public articleList: Array<ArticelModel>;

    //constructor(private articleServices: ArticleService)
    //{
    //    this.articleList = new Array<ArticelModel>();
    //}

    //ngOnInit() {
    //    this.getAllArticles();
       
    //}

    //getAllArticles(): void {
    //    this.articleServices.getAllArticle()
    //        .subscribe(res => {
    //            var data: any = res;
    //            this.articleList = data.Items;
    //        },
    //        error => console.error('Error: ' + error));
    //}

    ngOnInit() {
        this.getAllArticles();
    }

    constructor(private articleService: ArticleService) {
        //this.articleList = new Array<ArticelModel>();

        //this.serverService.searchProjectManagers(query, projectName).subscribe(result => {
        //    console.log("search project manager");
        //    if (this.server.ProjectManagers != null && this.server.ProjectManagers.length > 0) {
        //        for (var item of this.server.ProjectManagers) {
        //            result = result.filter(t => t.Email.indexOf(item.Email) == -1);
        //        }
        //    }
        //    this.filteredProjectManagers = result;
        //});

        //http.get(originUrl + '/api/Article/GetAllArtices').subscribe(result => {
        //    this.articleList = result.json() as Array<ArticelModel>;
        //});
        this.articleList = new Array<ArticelModel>();
        
    }

    getAllArticles() {
        this.articleService.getAllArticle().subscribe(result => {
            this.articleList = result;
        });
    }
}
