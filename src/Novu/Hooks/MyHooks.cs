package hooks

import (
	"net/http"
)

type ExampleHook struct{}

var (
	_ sdkInitHook       = (*ExampleHook)(nil)
	_ beforeRequestHook = (*ExampleHook)(nil)
	_ afterSuccessHook  = (*ExampleHook)(nil)
	_ afterErrorHook    = (*ExampleHook)(nil)
)

func (i *ExampleHook) SDKInit(baseURL string, client HTTPClient) (string, HTTPClient) {
	// modify the baseURL or wrap the client used by the SDK here and return the updated values
	return baseURL, client
}

func (i *ExampleHook) BeforeRequest(hookCtx BeforeRequestContext, req *http.Request) (*http.Request, error) {
	// modify the request object before it is sent, such as adding headers or query parameters, or return an error to stop the request from being sent
	return req, nil
}

func (i *ExampleHook) AfterSuccess(hookCtx AfterSuccessContext, res *http.Response) (*http.Response, error) {
	// modify the response object before deserialization or return an error to stop the response from being deserialized
	return res, nil
}

func (i *ExampleHook) AfterError(hookCtx AfterErrorContext, res *http.Response, err error) (*http.Response, error) {
	// modify the response before it is deserialized as a custom error or the error object before it is returned or return an error wrapped in the FailEarly error in this package to exit from the hook chain early
	return res, err
}