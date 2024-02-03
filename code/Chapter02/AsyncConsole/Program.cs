HttpClient client = new();

HttpResponseMessage response =
  await client.GetAsync("https://obi2.kean.edu/~ykumar@kean.edu/unit2/self_submission_email.txt");

WriteLine("Professor's home page has {0:N0} bytes.",
  response.Content.Headers.ContentLength);
// add 2 scripts from Unit3 - resources
