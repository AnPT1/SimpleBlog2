export class NewArticelModel {
    constructor(
        public Id: number,
        public CategoryId: string,
        public ArticleTitle: string,
        public ArticleContent: string,
        public CreateDate: Date)
    { }
}