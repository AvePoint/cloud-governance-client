/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import * as runtime from '../runtime';
import {
    ApiError,
    ApiErrorFromJSON,
    ApiErrorToJSON,
    ApiUser,
    ApiUserFromJSON,
    ApiUserToJSON,
    ChangeGroupSettingCheckResult,
    ChangeGroupSettingCheckResultFromJSON,
    ChangeGroupSettingCheckResultToJSON,
    ChangeGroupSettingService,
    ChangeGroupSettingServiceFromJSON,
    ChangeGroupSettingServiceToJSON,
    ChangeGroupSettingValidationParameter,
    ChangeGroupSettingValidationParameterFromJSON,
    ChangeGroupSettingValidationParameterToJSON,
    ChangeListSettingService,
    ChangeListSettingServiceFromJSON,
    ChangeListSettingServiceToJSON,
    ChangeListSettingValidateResult,
    ChangeListSettingValidateResultFromJSON,
    ChangeListSettingValidateResultToJSON,
    ChangePermissionService,
    ChangePermissionServiceFromJSON,
    ChangePermissionServiceToJSON,
    ChangePermissionValidateResult,
    ChangePermissionValidateResultFromJSON,
    ChangePermissionValidateResultToJSON,
    ChangeSiteContactService,
    ChangeSiteContactServiceFromJSON,
    ChangeSiteContactServiceToJSON,
    ChangeSiteContactValidateResult,
    ChangeSiteContactValidateResultFromJSON,
    ChangeSiteContactValidateResultToJSON,
    ChangeSiteSettingService,
    ChangeSiteSettingServiceFromJSON,
    ChangeSiteSettingServiceToJSON,
    ChangeSiteSettingValidateResult,
    ChangeSiteSettingValidateResultFromJSON,
    ChangeSiteSettingValidateResultToJSON,
    ChangeWebContactService,
    ChangeWebContactServiceFromJSON,
    ChangeWebContactServiceToJSON,
    ChangeWebContactValidateResult,
    ChangeWebContactValidateResultFromJSON,
    ChangeWebContactValidateResultToJSON,
    ChangeWebSettingService,
    ChangeWebSettingServiceFromJSON,
    ChangeWebSettingServiceToJSON,
    ChangeWebUrlValidateResult,
    ChangeWebUrlValidateResultFromJSON,
    ChangeWebUrlValidateResultToJSON,
    ClonePermissionService,
    ClonePermissionServiceFromJSON,
    ClonePermissionServiceToJSON,
    ClonePermissionValidateResult,
    ClonePermissionValidateResultFromJSON,
    ClonePermissionValidateResultToJSON,
    ContentMoveProfiles,
    ContentMoveProfilesFromJSON,
    ContentMoveProfilesToJSON,
    ContentMoveService,
    ContentMoveServiceFromJSON,
    ContentMoveServiceToJSON,
    ContentMoveUrlValidationResult,
    ContentMoveUrlValidationResultFromJSON,
    ContentMoveUrlValidationResultToJSON,
    CreateGroupService,
    CreateGroupServiceFromJSON,
    CreateGroupServiceToJSON,
    CreateGuestUserService,
    CreateGuestUserServiceFromJSON,
    CreateGuestUserServiceToJSON,
    CreateGuestUserValidationResult,
    CreateGuestUserValidationResultFromJSON,
    CreateGuestUserValidationResultToJSON,
    CreateListService,
    CreateListServiceFromJSON,
    CreateListServiceToJSON,
    CreateListUrlValidationResult,
    CreateListUrlValidationResultFromJSON,
    CreateListUrlValidationResultToJSON,
    CreateSiteService,
    CreateSiteServiceFromJSON,
    CreateSiteServiceToJSON,
    CreateWebService,
    CreateWebServiceFromJSON,
    CreateWebServiceToJSON,
    CreateWebUrlValidationResult,
    CreateWebUrlValidationResultFromJSON,
    CreateWebUrlValidationResultToJSON,
    CreateWebValidationParameter,
    CreateWebValidationParameterFromJSON,
    CreateWebValidationParameterToJSON,
    GrantPermissionService,
    GrantPermissionServiceFromJSON,
    GrantPermissionServiceToJSON,
    GrantPermissionUrlValidationResult,
    GrantPermissionUrlValidationResultFromJSON,
    GrantPermissionUrlValidationResultToJSON,
    GroupLifecycleService,
    GroupLifecycleServiceFromJSON,
    GroupLifecycleServiceToJSON,
    GroupLifecycleValidateResult,
    GroupLifecycleValidateResultFromJSON,
    GroupLifecycleValidateResultToJSON,
    GroupValidationParameter,
    GroupValidationParameterFromJSON,
    GroupValidationParameterToJSON,
    ListValidationParameter,
    ListValidationParameterFromJSON,
    ListValidationParameterToJSON,
    ManagePermissionService,
    ManagePermissionServiceFromJSON,
    ManagePermissionServiceToJSON,
    ManagePermissionValidateResult,
    ManagePermissionValidateResultFromJSON,
    ManagePermissionValidateResultToJSON,
    ObjectValidateResult,
    ObjectValidateResultFromJSON,
    ObjectValidateResultToJSON,
    ServiceForRequest,
    ServiceForRequestFromJSON,
    ServiceForRequestToJSON,
    ServiceListPageResult,
    ServiceListPageResultFromJSON,
    ServiceListPageResultToJSON,
    SiteLifecycleService,
    SiteLifecycleServiceFromJSON,
    SiteLifecycleServiceToJSON,
    SiteLifecycleValidateResult,
    SiteLifecycleValidateResultFromJSON,
    SiteLifecycleValidateResultToJSON,
    SiteValidationParameter,
    SiteValidationParameterFromJSON,
    SiteValidationParameterToJSON,
    WebLifecycleService,
    WebLifecycleServiceFromJSON,
    WebLifecycleServiceToJSON,
    WebLifecycleValidateResult,
    WebLifecycleValidateResultFromJSON,
    WebLifecycleValidateResultToJSON,
} from '../models';

export interface GetChangeGroupSettingServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetChangeListSettingServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetChangePermissionServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetChangeSiteContactServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetChangeSiteSettingServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetChangeWebContactServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetChangeWebSettingsServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetClonePermissionServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetContentMoveServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetCreateGroupServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetCreateGuestUserServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetCreateListServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetCreateSiteServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetCreateWebServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetCustomServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetGrantPermissionServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetGroupLifecycleServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetManagePermissionServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetMyServicesRequest {
    search?: string;
}

export interface GetServiceIdRequest {
    name: string;
}

export interface GetSiteLifecycleServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface GetWebLifecycleServiceRequest {
    id: string;
    questionnaireId?: string;
}

export interface ValidateEmailForCreateGuestUserServiceRequest {
    id: string;
    email: string;
}

export interface ValidateForChangeGroupSettingServiceRequest {
    id: string;
    changeGroupSettingValidationParameter?: ChangeGroupSettingValidationParameter;
}

export interface ValidateForChangeListSettingServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForChangePermissionServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForChangeSiteContactServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForChangeSiteSettingServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForChangeWebContactServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForChangeWebSettingServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForClonePermissionServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForContentMoveServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForCreateGuestUserServiceRequest {
    id: string;
    requestId?: string;
    apiUser?: Array<ApiUser>;
}

export interface ValidateForCreateListServiceRequest {
    id: string;
    listValidationParameter?: ListValidationParameter;
}

export interface ValidateForCreateWebServiceRequest {
    id: string;
    createWebValidationParameter?: CreateWebValidationParameter;
}

export interface ValidateForGrantPermissionServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForGroupLifecycleServiceRequest {
    id: string;
    groupValidationParameter?: GroupValidationParameter;
}

export interface ValidateForManagePermissionServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForSiteLifecycleServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

export interface ValidateForWebLifecycleServiceRequest {
    id: string;
    siteValidationParameter?: SiteValidationParameter;
}

/**
 * 
 */
export class ServicesApi extends runtime.BaseAPI {

    /**
     * get change group setting service
     */
    async getChangeGroupSettingServiceRaw(requestParameters: GetChangeGroupSettingServiceRequest): Promise<runtime.ApiResponse<ChangeGroupSettingService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeGroupSettingService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changegroupsetting/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeGroupSettingServiceFromJSON(jsonValue));
    }

    /**
     * get change group setting service
     */
    async getChangeGroupSettingService(requestParameters: GetChangeGroupSettingServiceRequest): Promise<ChangeGroupSettingService> {
        const response = await this.getChangeGroupSettingServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change list setting service
     */
    async getChangeListSettingServiceRaw(requestParameters: GetChangeListSettingServiceRequest): Promise<runtime.ApiResponse<ChangeListSettingService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeListSettingService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changelistsetting/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeListSettingServiceFromJSON(jsonValue));
    }

    /**
     * get change list setting service
     */
    async getChangeListSettingService(requestParameters: GetChangeListSettingServiceRequest): Promise<ChangeListSettingService> {
        const response = await this.getChangeListSettingServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change permission service
     */
    async getChangePermissionServiceRaw(requestParameters: GetChangePermissionServiceRequest): Promise<runtime.ApiResponse<ChangePermissionService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangePermissionService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changepermission/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangePermissionServiceFromJSON(jsonValue));
    }

    /**
     * get change permission service
     */
    async getChangePermissionService(requestParameters: GetChangePermissionServiceRequest): Promise<ChangePermissionService> {
        const response = await this.getChangePermissionServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change site contact service
     */
    async getChangeSiteContactServiceRaw(requestParameters: GetChangeSiteContactServiceRequest): Promise<runtime.ApiResponse<ChangeSiteContactService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeSiteContactService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changesitecontact/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeSiteContactServiceFromJSON(jsonValue));
    }

    /**
     * get change site contact service
     */
    async getChangeSiteContactService(requestParameters: GetChangeSiteContactServiceRequest): Promise<ChangeSiteContactService> {
        const response = await this.getChangeSiteContactServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change site setting service
     */
    async getChangeSiteSettingServiceRaw(requestParameters: GetChangeSiteSettingServiceRequest): Promise<runtime.ApiResponse<ChangeSiteSettingService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeSiteSettingService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changesitesetting/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeSiteSettingServiceFromJSON(jsonValue));
    }

    /**
     * get change site setting service
     */
    async getChangeSiteSettingService(requestParameters: GetChangeSiteSettingServiceRequest): Promise<ChangeSiteSettingService> {
        const response = await this.getChangeSiteSettingServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for change web contact service
     */
    async getChangeWebContactServiceRaw(requestParameters: GetChangeWebContactServiceRequest): Promise<runtime.ApiResponse<ChangeWebContactService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeWebContactService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changewebcontact/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeWebContactServiceFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for change web contact service
     */
    async getChangeWebContactService(requestParameters: GetChangeWebContactServiceRequest): Promise<ChangeWebContactService> {
        const response = await this.getChangeWebContactServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get change web setting service
     */
    async getChangeWebSettingsServiceRaw(requestParameters: GetChangeWebSettingsServiceRequest): Promise<runtime.ApiResponse<ChangeWebSettingService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getChangeWebSettingsService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changewebsettings/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeWebSettingServiceFromJSON(jsonValue));
    }

    /**
     * get change web setting service
     */
    async getChangeWebSettingsService(requestParameters: GetChangeWebSettingsServiceRequest): Promise<ChangeWebSettingService> {
        const response = await this.getChangeWebSettingsServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get clone permission service
     */
    async getClonePermissionServiceRaw(requestParameters: GetClonePermissionServiceRequest): Promise<runtime.ApiResponse<ClonePermissionService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getClonePermissionService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/clonepermission/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ClonePermissionServiceFromJSON(jsonValue));
    }

    /**
     * get clone permission service
     */
    async getClonePermissionService(requestParameters: GetClonePermissionServiceRequest): Promise<ClonePermissionService> {
        const response = await this.getClonePermissionServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get content move profiles from cloud management
     */
    async getContentMoveProfilesRaw(): Promise<runtime.ApiResponse<ContentMoveProfiles>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/contentmove/profiles`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ContentMoveProfilesFromJSON(jsonValue));
    }

    /**
     * get content move profiles from cloud management
     */
    async getContentMoveProfiles(): Promise<ContentMoveProfiles> {
        const response = await this.getContentMoveProfilesRaw();
        return await response.value();
    }

    /**
     * get content move service
     */
    async getContentMoveServiceRaw(requestParameters: GetContentMoveServiceRequest): Promise<runtime.ApiResponse<ContentMoveService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getContentMoveService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/contentmove/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ContentMoveServiceFromJSON(jsonValue));
    }

    /**
     * get content move service
     */
    async getContentMoveService(requestParameters: GetContentMoveServiceRequest): Promise<ContentMoveService> {
        const response = await this.getContentMoveServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get create group service
     */
    async getCreateGroupServiceRaw(requestParameters: GetCreateGroupServiceRequest): Promise<runtime.ApiResponse<CreateGroupService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCreateGroupService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/creategroup/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateGroupServiceFromJSON(jsonValue));
    }

    /**
     * get create group service
     */
    async getCreateGroupService(requestParameters: GetCreateGroupServiceRequest): Promise<CreateGroupService> {
        const response = await this.getCreateGroupServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get create group service
     */
    async getCreateGuestUserServiceRaw(requestParameters: GetCreateGuestUserServiceRequest): Promise<runtime.ApiResponse<CreateGuestUserService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCreateGuestUserService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/createguestuser/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateGuestUserServiceFromJSON(jsonValue));
    }

    /**
     * get create group service
     */
    async getCreateGuestUserService(requestParameters: GetCreateGuestUserServiceRequest): Promise<CreateGuestUserService> {
        const response = await this.getCreateGuestUserServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get create list service
     */
    async getCreateListServiceRaw(requestParameters: GetCreateListServiceRequest): Promise<runtime.ApiResponse<CreateListService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCreateListService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/createlist/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateListServiceFromJSON(jsonValue));
    }

    /**
     * get create list service
     */
    async getCreateListService(requestParameters: GetCreateListServiceRequest): Promise<CreateListService> {
        const response = await this.getCreateListServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get create site service
     */
    async getCreateSiteServiceRaw(requestParameters: GetCreateSiteServiceRequest): Promise<runtime.ApiResponse<CreateSiteService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCreateSiteService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/createsite/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateSiteServiceFromJSON(jsonValue));
    }

    /**
     * get create site service
     */
    async getCreateSiteService(requestParameters: GetCreateSiteServiceRequest): Promise<CreateSiteService> {
        const response = await this.getCreateSiteServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get create web service
     */
    async getCreateWebServiceRaw(requestParameters: GetCreateWebServiceRequest): Promise<runtime.ApiResponse<CreateWebService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCreateWebService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/createweb/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateWebServiceFromJSON(jsonValue));
    }

    /**
     * get create web service
     */
    async getCreateWebService(requestParameters: GetCreateWebServiceRequest): Promise<CreateWebService> {
        const response = await this.getCreateWebServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get custom service
     */
    async getCustomServiceRaw(requestParameters: GetCustomServiceRequest): Promise<runtime.ApiResponse<ServiceForRequest>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getCustomService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/custom/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ServiceForRequestFromJSON(jsonValue));
    }

    /**
     * get custom service
     */
    async getCustomService(requestParameters: GetCustomServiceRequest): Promise<ServiceForRequest> {
        const response = await this.getCustomServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get grant permission service
     */
    async getGrantPermissionServiceRaw(requestParameters: GetGrantPermissionServiceRequest): Promise<runtime.ApiResponse<GrantPermissionService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getGrantPermissionService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/grantpermission/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => GrantPermissionServiceFromJSON(jsonValue));
    }

    /**
     * get grant permission service
     */
    async getGrantPermissionService(requestParameters: GetGrantPermissionServiceRequest): Promise<GrantPermissionService> {
        const response = await this.getGrantPermissionServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get group lifecycle service
     */
    async getGroupLifecycleServiceRaw(requestParameters: GetGroupLifecycleServiceRequest): Promise<runtime.ApiResponse<GroupLifecycleService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getGroupLifecycleService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/grouplifecycle/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => GroupLifecycleServiceFromJSON(jsonValue));
    }

    /**
     * get group lifecycle service
     */
    async getGroupLifecycleService(requestParameters: GetGroupLifecycleServiceRequest): Promise<GroupLifecycleService> {
        const response = await this.getGroupLifecycleServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get manage permission service
     */
    async getManagePermissionServiceRaw(requestParameters: GetManagePermissionServiceRequest): Promise<runtime.ApiResponse<ManagePermissionService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getManagePermissionService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/managepermission/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ManagePermissionServiceFromJSON(jsonValue));
    }

    /**
     * get manage permission service
     */
    async getManagePermissionService(requestParameters: GetManagePermissionServiceRequest): Promise<ManagePermissionService> {
        const response = await this.getManagePermissionServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get services that can be used to start a request
     */
    async getMyServicesRaw(requestParameters: GetMyServicesRequest): Promise<runtime.ApiResponse<ServiceListPageResult>> {
        const queryParameters: any = {};

        if (requestParameters.search !== undefined) {
            queryParameters['search'] = requestParameters.search;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/my`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ServiceListPageResultFromJSON(jsonValue));
    }

    /**
     * get services that can be used to start a request
     */
    async getMyServices(requestParameters: GetMyServicesRequest): Promise<ServiceListPageResult> {
        const response = await this.getMyServicesRaw(requestParameters);
        return await response.value();
    }

    /**
     * get service id by service name
     */
    async getServiceIdRaw(requestParameters: GetServiceIdRequest): Promise<runtime.ApiResponse<string>> {
        if (requestParameters.name === null || requestParameters.name === undefined) {
            throw new runtime.RequiredError('name','Required parameter requestParameters.name was null or undefined when calling getServiceId.');
        }

        const queryParameters: any = {};

        if (requestParameters.name !== undefined) {
            queryParameters['name'] = requestParameters.name;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/id`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse<any>(response);
    }

    /**
     * get service id by service name
     */
    async getServiceId(requestParameters: GetServiceIdRequest): Promise<string> {
        const response = await this.getServiceIdRaw(requestParameters);
        return await response.value();
    }

    /**
     * get site lifecycle service
     */
    async getSiteLifecycleServiceRaw(requestParameters: GetSiteLifecycleServiceRequest): Promise<runtime.ApiResponse<SiteLifecycleService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getSiteLifecycleService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/sitelifecycle/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => SiteLifecycleServiceFromJSON(jsonValue));
    }

    /**
     * get site lifecycle service
     */
    async getSiteLifecycleService(requestParameters: GetSiteLifecycleServiceRequest): Promise<SiteLifecycleService> {
        const response = await this.getSiteLifecycleServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * get web lifecycle service
     */
    async getWebLifecycleServiceRaw(requestParameters: GetWebLifecycleServiceRequest): Promise<runtime.ApiResponse<WebLifecycleService>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling getWebLifecycleService.');
        }

        const queryParameters: any = {};

        if (requestParameters.questionnaireId !== undefined) {
            queryParameters['questionnaireId'] = requestParameters.questionnaireId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/weblifecycle/{id}`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => WebLifecycleServiceFromJSON(jsonValue));
    }

    /**
     * get web lifecycle service
     */
    async getWebLifecycleService(requestParameters: GetWebLifecycleServiceRequest): Promise<WebLifecycleService> {
        const response = await this.getWebLifecycleServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate guest user email
     */
    async validateEmailForCreateGuestUserServiceRaw(requestParameters: ValidateEmailForCreateGuestUserServiceRequest): Promise<runtime.ApiResponse<ObjectValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateEmailForCreateGuestUserService.');
        }

        if (requestParameters.email === null || requestParameters.email === undefined) {
            throw new runtime.RequiredError('email','Required parameter requestParameters.email was null or undefined when calling validateEmailForCreateGuestUserService.');
        }

        const queryParameters: any = {};

        if (requestParameters.email !== undefined) {
            queryParameters['email'] = requestParameters.email;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/createguestuser/{id}/email/validate`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ObjectValidateResultFromJSON(jsonValue));
    }

    /**
     * validate guest user email
     */
    async validateEmailForCreateGuestUserService(requestParameters: ValidateEmailForCreateGuestUserServiceRequest): Promise<ObjectValidateResult> {
        const response = await this.validateEmailForCreateGuestUserServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for change group setting service
     */
    async validateForChangeGroupSettingServiceRaw(requestParameters: ValidateForChangeGroupSettingServiceRequest): Promise<runtime.ApiResponse<ChangeGroupSettingCheckResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForChangeGroupSettingService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changegroupsetting/{id}/group/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ChangeGroupSettingValidationParameterToJSON(requestParameters.changeGroupSettingValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeGroupSettingCheckResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for change group setting service
     */
    async validateForChangeGroupSettingService(requestParameters: ValidateForChangeGroupSettingServiceRequest): Promise<ChangeGroupSettingCheckResult> {
        const response = await this.validateForChangeGroupSettingServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for change list setting service
     */
    async validateForChangeListSettingServiceRaw(requestParameters: ValidateForChangeListSettingServiceRequest): Promise<runtime.ApiResponse<ChangeListSettingValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForChangeListSettingService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changelistsetting/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeListSettingValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for change list setting service
     */
    async validateForChangeListSettingService(requestParameters: ValidateForChangeListSettingServiceRequest): Promise<ChangeListSettingValidateResult> {
        const response = await this.validateForChangeListSettingServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for change permission service
     */
    async validateForChangePermissionServiceRaw(requestParameters: ValidateForChangePermissionServiceRequest): Promise<runtime.ApiResponse<ChangePermissionValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForChangePermissionService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changepermission/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangePermissionValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for change permission service
     */
    async validateForChangePermissionService(requestParameters: ValidateForChangePermissionServiceRequest): Promise<ChangePermissionValidateResult> {
        const response = await this.validateForChangePermissionServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for change site contact service
     */
    async validateForChangeSiteContactServiceRaw(requestParameters: ValidateForChangeSiteContactServiceRequest): Promise<runtime.ApiResponse<ChangeSiteContactValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForChangeSiteContactService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changesitecontact/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeSiteContactValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for change site contact service
     */
    async validateForChangeSiteContactService(requestParameters: ValidateForChangeSiteContactServiceRequest): Promise<ChangeSiteContactValidateResult> {
        const response = await this.validateForChangeSiteContactServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for change site setting service
     */
    async validateForChangeSiteSettingServiceRaw(requestParameters: ValidateForChangeSiteSettingServiceRequest): Promise<runtime.ApiResponse<ChangeSiteSettingValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForChangeSiteSettingService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changesitesetting/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeSiteSettingValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for change site setting service
     */
    async validateForChangeSiteSettingService(requestParameters: ValidateForChangeSiteSettingServiceRequest): Promise<ChangeSiteSettingValidateResult> {
        const response = await this.validateForChangeSiteSettingServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for change web contact service
     */
    async validateForChangeWebContactServiceRaw(requestParameters: ValidateForChangeWebContactServiceRequest): Promise<runtime.ApiResponse<ChangeWebContactValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForChangeWebContactService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changewebcontact/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeWebContactValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for change web contact service
     */
    async validateForChangeWebContactService(requestParameters: ValidateForChangeWebContactServiceRequest): Promise<ChangeWebContactValidateResult> {
        const response = await this.validateForChangeWebContactServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for change web setting service
     */
    async validateForChangeWebSettingServiceRaw(requestParameters: ValidateForChangeWebSettingServiceRequest): Promise<runtime.ApiResponse<ChangeWebUrlValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForChangeWebSettingService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/changewebsettings/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ChangeWebUrlValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for change web setting service
     */
    async validateForChangeWebSettingService(requestParameters: ValidateForChangeWebSettingServiceRequest): Promise<ChangeWebUrlValidateResult> {
        const response = await this.validateForChangeWebSettingServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for clone permission service
     */
    async validateForClonePermissionServiceRaw(requestParameters: ValidateForClonePermissionServiceRequest): Promise<runtime.ApiResponse<ClonePermissionValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForClonePermissionService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/clonepermission/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ClonePermissionValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for clone permission service
     */
    async validateForClonePermissionService(requestParameters: ValidateForClonePermissionServiceRequest): Promise<ClonePermissionValidateResult> {
        const response = await this.validateForClonePermissionServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for content move service
     */
    async validateForContentMoveServiceRaw(requestParameters: ValidateForContentMoveServiceRequest): Promise<runtime.ApiResponse<ContentMoveUrlValidationResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForContentMoveService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/contentmove/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ContentMoveUrlValidationResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for content move service
     */
    async validateForContentMoveService(requestParameters: ValidateForContentMoveServiceRequest): Promise<ContentMoveUrlValidationResult> {
        const response = await this.validateForContentMoveServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate groups can invite
     */
    async validateForCreateGuestUserServiceRaw(requestParameters: ValidateForCreateGuestUserServiceRequest): Promise<runtime.ApiResponse<Array<CreateGuestUserValidationResult>>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForCreateGuestUserService.');
        }

        const queryParameters: any = {};

        if (requestParameters.requestId !== undefined) {
            queryParameters['requestId'] = requestParameters.requestId;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/createguestuser/{id}/group/validate`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: requestParameters.apiUser.map(ApiUserToJSON),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(CreateGuestUserValidationResultFromJSON));
    }

    /**
     * validate groups can invite
     */
    async validateForCreateGuestUserService(requestParameters: ValidateForCreateGuestUserServiceRequest): Promise<Array<CreateGuestUserValidationResult>> {
        const response = await this.validateForCreateGuestUserServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for create list service
     */
    async validateForCreateListServiceRaw(requestParameters: ValidateForCreateListServiceRequest): Promise<runtime.ApiResponse<CreateListUrlValidationResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForCreateListService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/createlist/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ListValidationParameterToJSON(requestParameters.listValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateListUrlValidationResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for create list service
     */
    async validateForCreateListService(requestParameters: ValidateForCreateListServiceRequest): Promise<CreateListUrlValidationResult> {
        const response = await this.validateForCreateListServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for create web service
     */
    async validateForCreateWebServiceRaw(requestParameters: ValidateForCreateWebServiceRequest): Promise<runtime.ApiResponse<CreateWebUrlValidationResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForCreateWebService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/createweb/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CreateWebValidationParameterToJSON(requestParameters.createWebValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => CreateWebUrlValidationResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for create web service
     */
    async validateForCreateWebService(requestParameters: ValidateForCreateWebServiceRequest): Promise<CreateWebUrlValidationResult> {
        const response = await this.validateForCreateWebServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for grant permission service
     */
    async validateForGrantPermissionServiceRaw(requestParameters: ValidateForGrantPermissionServiceRequest): Promise<runtime.ApiResponse<GrantPermissionUrlValidationResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForGrantPermissionService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/grantpermission/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => GrantPermissionUrlValidationResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for grant permission service
     */
    async validateForGrantPermissionService(requestParameters: ValidateForGrantPermissionServiceRequest): Promise<GrantPermissionUrlValidationResult> {
        const response = await this.validateForGrantPermissionServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for group lifecycle service
     */
    async validateForGroupLifecycleServiceRaw(requestParameters: ValidateForGroupLifecycleServiceRequest): Promise<runtime.ApiResponse<GroupLifecycleValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForGroupLifecycleService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/grouplifecycle/{id}/group/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: GroupValidationParameterToJSON(requestParameters.groupValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => GroupLifecycleValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for group lifecycle service
     */
    async validateForGroupLifecycleService(requestParameters: ValidateForGroupLifecycleServiceRequest): Promise<GroupLifecycleValidateResult> {
        const response = await this.validateForGroupLifecycleServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for manage permission service
     */
    async validateForManagePermissionServiceRaw(requestParameters: ValidateForManagePermissionServiceRequest): Promise<runtime.ApiResponse<ManagePermissionValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForManagePermissionService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/managepermission/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => ManagePermissionValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for manage permission service
     */
    async validateForManagePermissionService(requestParameters: ValidateForManagePermissionServiceRequest): Promise<ManagePermissionValidateResult> {
        const response = await this.validateForManagePermissionServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for site lifecycle service
     */
    async validateForSiteLifecycleServiceRaw(requestParameters: ValidateForSiteLifecycleServiceRequest): Promise<runtime.ApiResponse<SiteLifecycleValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForSiteLifecycleService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/sitelifecycle/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => SiteLifecycleValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for site lifecycle service
     */
    async validateForSiteLifecycleService(requestParameters: ValidateForSiteLifecycleServiceRequest): Promise<SiteLifecycleValidateResult> {
        const response = await this.validateForSiteLifecycleServiceRaw(requestParameters);
        return await response.value();
    }

    /**
     * validate permissions, scope for web lifecycle service
     */
    async validateForWebLifecycleServiceRaw(requestParameters: ValidateForWebLifecycleServiceRequest): Promise<runtime.ApiResponse<WebLifecycleValidateResult>> {
        if (requestParameters.id === null || requestParameters.id === undefined) {
            throw new runtime.RequiredError('id','Required parameter requestParameters.id was null or undefined when calling validateForWebLifecycleService.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["clientSecret"] = this.configuration.apiKey("clientSecret"); // clientSecret authentication
        }

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["userPrincipalName"] = this.configuration.apiKey("userPrincipalName"); // userPrincipalName authentication
        }

        headerParameters["User-Agent"]="(sdk/typescript/4.7.4)";
        const response = await this.request({
            path: `/services/weblifecycle/{id}/url/validation`.replace(`{${"id"}}`, encodeURIComponent(String(requestParameters.id))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: SiteValidationParameterToJSON(requestParameters.siteValidationParameter),
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => WebLifecycleValidateResultFromJSON(jsonValue));
    }

    /**
     * validate permissions, scope for web lifecycle service
     */
    async validateForWebLifecycleService(requestParameters: ValidateForWebLifecycleServiceRequest): Promise<WebLifecycleValidateResult> {
        const response = await this.validateForWebLifecycleServiceRaw(requestParameters);
        return await response.value();
    }

}
