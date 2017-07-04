import { Injectable, Inject } from '@angular/core';
import { Http, Headers, Response, Request } from '@angular/http';
import { Router } from '@angular/router';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/throw';

import { ArticelModel } from '../models/article.model';
import { NewArticelModel } from '../models/new-article.model';
@Injectable()
export class ArticleService {

    private _serverAPI: string = '/api/article';
    constructor(public http: Http) { }

    //getAllArticle( @Inject('ORIGIN_URL') originUrl: string) {
    //    var uri = originUrl + this._serverAPI ;
    //    return this.http.get(uri).map((response: Response) => response.json());
    //}

    getAllArticle() {
        var uri = this._serverAPI + '/get-all-article';
        return this.http.get(uri).map((response: Response) => response.json());
    }

    createNewArticle(newArticle: NewArticelModel) {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        return this.http.patch(this._serverAPI + '/new-article', JSON.stringify(newArticle), { headers: headers })
            .map((response: Response) => response.json());
    }
}