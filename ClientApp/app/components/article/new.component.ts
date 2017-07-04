import { Component, OnInit, Inject } from '@angular/core';
import { ArticleService } from '../services/article.service';
import { NewArticelModel } from '../models/new-article.model';
import { Http } from '@angular/http'
import { FormsModule } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    selector: 'newarticle',
    templateUrl: './new.component.html'
})
export class NewArticleComponent {

    public showArticleData: NewArticelModel;
    public newArticleData: NewArticelModel;
    ngOnInit() {
    }

    constructor(private articleService: ArticleService, private router: Router) {
    }

    createNewArticle() {
        this.newArticleData = JSON.parse(JSON.stringify(this.showArticleData));
        this.articleService.createNewArticle(this.newArticleData)
            .subscribe(res => {
                if (!res.Succeeded) {
                    this.router.navigate(['article']);
                }
                else {
                   //Nothing
                }
                
            });
    }
}
