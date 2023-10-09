import { EmployeeTemplatePage } from './app.po';

describe('Employee App', function() {
  let page: EmployeeTemplatePage;

  beforeEach(() => {
    page = new EmployeeTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
