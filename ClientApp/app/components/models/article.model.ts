export class ArticelModel {
    constructor(
        public ArticleId: number,
        public Category: string,
        public Author: string,
        public ArticleTitle: string,
        public ArticleContent: string,
        public CreateDate: Date)
    { }
}