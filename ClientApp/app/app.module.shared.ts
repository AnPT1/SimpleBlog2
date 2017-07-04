import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { TopMenuComponent } from './components/navmenu/topmenu.component';
import { HomeComponent } from './components/home/home.component';
import { ArticleComponent } from './components/article/article.component';
import { NewArticleComponent } from './components/article/new.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { ArticleService } from "./components/services/article.service";

export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        TopMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        ArticleComponent,
        NewArticleComponent
    ],
    providers: [ArticleService],
    imports: [FormsModule, BrowserModule, ReactiveFormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'article', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'article', component: ArticleComponent },
            { path: 'newarticle', component: NewArticleComponent },
            { path: '**', redirectTo: 'article' }
        ])
    ]
};
